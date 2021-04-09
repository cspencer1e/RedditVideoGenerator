using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditVideoGenerator.Tools
{
    public static class VideoTools
    {
        public const string tempFolderName = "temp";
        public static string imgFolderPath = Path.Combine(tempFolderName, "img");
        public static string ttsFolderPath = Path.Combine(tempFolderName, "tts");
        public static string vidFolderPath = Path.Combine(tempFolderName, "vid");

        public static void SetupTempFolders()
        {
            Directory.CreateDirectory(imgFolderPath);
            Directory.CreateDirectory(ttsFolderPath);
            Directory.CreateDirectory(vidFolderPath);
        }

        public static void CleanupTempFolders()
        {
            if (Directory.Exists(tempFolderName)) Directory.Delete(tempFolderName, true);
        }

        public static void RunFfmpeg(string args)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "ffmpeg.exe";
            startInfo.Arguments = args;
            startInfo.RedirectStandardOutput = true;
            //startInfo.RedirectStandardError = true;

            Debug.WriteLine(string.Format(
                "Executing \"{0}\" with arguments \"{1}\".\r\n",
                startInfo.FileName,
                startInfo.Arguments));

            try
            {
                using (Process process = Process.Start(startInfo))
                {
                    while (!process.StandardOutput.EndOfStream)
                    {
                        string line = process.StandardOutput.ReadLine();
                        Debug.WriteLine(line);
                    }

                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public static void GenerateVideo(string backgroundVideoPath = "space.mp4", string outputVideoPath = "finishedvideo.mp4", string quality = "ultrafast")
        {
            var seconds = File.ReadAllText(Path.Combine(VideoTools.tempFolderName, "ttsLengths.txt")).Split(',').Select(s => int.Parse(s)).ToList();

            int duration = 0;
            foreach (var s in seconds)
            {
                duration += s;
            }

            VideoTools.RunFfmpeg($"-y -i {backgroundVideoPath} -filter_complex \"scale=854:480, loop=-1:32767:0\" -t {duration} -b:v 600k -pix_fmt yuv420p -preset {quality} {Path.Combine(VideoTools.tempFolderName, "bg.mp4")}");

            int position = 0;
            for (int i = 0; i < seconds.Count(); i++)
            {
                VideoTools.RunFfmpeg($"-y -i {(i == 0 ? Path.Combine(VideoTools.tempFolderName, "bg.mp4") : Path.Combine(VideoTools.vidFolderPath, (i - 1) + ".mp4"))} -i {Path.Combine(VideoTools.imgFolderPath, i + ".png")}" +
                    $" -filter_complex \"[1:v]scale=854:480:force_original_aspect_ratio=decrease, [0:v]overlay = W/2-w/2:H/2-h/2:enable = 'between(t,{position},{position + seconds[i]})'\"" +
                    $" -pix_fmt yuv420p" +
                    $" -preset {quality} -async 1 {Path.Combine(VideoTools.vidFolderPath, i + ".mp4")}");

                VideoTools.RunFfmpeg($"-y -i {Path.Combine(VideoTools.vidFolderPath, i + ".mp4")} -itsoffset {position} -i {Path.Combine(VideoTools.ttsFolderPath, i + ".wav")} -map 0:0 -map 1:0 -c:v copy -preset {quality} -async 1 {Path.Combine(VideoTools.vidFolderPath, i + "a.mp4")}");
                VideoTools.RunFfmpeg($"-y -i {Path.Combine(VideoTools.vidFolderPath, i + "a.mp4")} {Path.Combine(VideoTools.vidFolderPath, i + ".wav")}");

                if (i==seconds.Count-1)
                {
                    VideoTools.RunFfmpeg($"-y -i {Path.Combine(VideoTools.vidFolderPath, i + "a.mp4")} {Path.Combine(VideoTools.vidFolderPath, "finish.mp4")}");
                }

                if (i > 0)
                {
                    if (File.Exists(Path.Combine(VideoTools.vidFolderPath, (i-1) + ".mp4"))) File.Delete(Path.Combine(VideoTools.vidFolderPath, (i-1) + ".mp4"));
                }
                if (File.Exists(Path.Combine(VideoTools.vidFolderPath, i + "a.mp4"))) File.Delete(Path.Combine(VideoTools.vidFolderPath, i + "a.mp4"));

                position += seconds[i];
            }

            string inputs = "";
            for (int i = 0; i < seconds.Count; i++)
            {
                inputs += $"-i {Path.Combine(VideoTools.vidFolderPath, i + ".wav")} ";
            }
            VideoTools.RunFfmpeg($"-y " + inputs + $"-filter_complex amix=inputs={seconds.Count}:duration=longest,volume={seconds.Count},dynaudnorm {Path.Combine(VideoTools.vidFolderPath, "finish.wav")}");

            for (int i=0;i<seconds.Count;i++)
            {
                if (File.Exists(Path.Combine(VideoTools.vidFolderPath, i + ".wav"))) File.Delete(Path.Combine(VideoTools.vidFolderPath, i + ".wav"));
            }

            VideoTools.RunFfmpeg($"-y -i {Path.Combine(VideoTools.vidFolderPath, $"finish.mp4")} -i {Path.Combine(VideoTools.vidFolderPath, "finish.wav")} -map 0:0 -map 1:0 -c:v copy -preset {quality} {outputVideoPath}");
        }
    }
}
