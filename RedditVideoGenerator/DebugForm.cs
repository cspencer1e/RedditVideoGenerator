using RedditSharp.Things;
using RedditVideoGenerator.Models;
using RedditVideoGenerator.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RedditVideoGenerator
{
    public partial class DebugForm : Form
    {
        RedditPost post;
        int comment = -1;

        public DebugForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoTools.CleanupTempFolders();
            post = RedditTools.GetPost("art", FromTime.Week, 7, 30);
            ImageTools.GeneratePostImages(post);
            TTSTools.SpeakPost(post, "Microsoft Anna", 2);
            VideoTools.GenerateVideo("default_bg.mp4");
            VideoTools.CleanupTempFolders();
            //pictureBox1.Image = ImageTools.PostImage(post);
            //pictureBox1.Image = ImageTools.PostImage("This is a test reddit post! :DD", "Test af!\n\nedit: hi", "tester123", "1.2k");

            //VideoTools.RunFfmpeg($"-framerate 1 -start_number 0 -y -i {Path.Combine(VideoTools.imgFolderPath, "%d.png")} -vf scale=1280:720 -pix_fmt yuv420p Project.mp4 ");
            //VideoTools.RunFfmpeg($"-y -i space.mp4 -vf \"scale=854:480\" default_bg.mp4");
            //VideoTools.RunFfmpeg($"-i space.gif {Path.Combine(VideoTools.tempFolderName, "background.gif")}");



            /*
            var seconds = File.ReadAllText(Path.Combine(VideoTools.tempFolderName, "ttsLengths.txt")).Split(',').Select(s => int.Parse(s)).ToList();

            int duration = 0;
            foreach (var s in seconds)
            {
                duration += s;
            }
            */
            //VideoTools.RunFfmpeg($"-y -i space.mp4 -filter_complex \"scale=854:480, loop=-1:32767:0\" -t {duration} -b:v 600k -pix_fmt yuv420p loopedbg.mp4");



            /*
            //int duration = 0;
            //foreach (var s in seconds)
            //{
            //    duration += int.Parse(s);
            //}
            //VideoTools.RunFfmpeg($"-y -ignore_loop 0 -t {duration} -i space.gif -pix_fmt yuv420p loopedbg.mp4");

            //-i {Path.Combine(VideoTools.imgFolderPath, i + ".png")} -ss {position} -i {Path.Combine(VideoTools.ttsFolderPath, i + ".wav")}

            int position = 0;
            string args = $"-i loopedbg.mp4 -i {Path.Combine(VideoTools.imgFolderPath, "%d.png")}";

            
            for (int i=0;i<seconds.Count();i++)
            {
                VideoTools.RunFfmpeg($"-y -i {(i==0 ? "loopedbg.mp4" : Path.Combine(VideoTools.vidFolderPath, (i-1)+".mp4"))} -i {Path.Combine(VideoTools.imgFolderPath, i + ".png")}" +
                    $" -filter_complex \"[1:v]scale=854:480:force_original_aspect_ratio=decrease, [0:v]overlay = W/2-w/2:H/2-h/2:enable = 'between(t,{position},{position + seconds[i]})'\"" +
                    $" -pix_fmt yuv420p" +
                    $" -preset ultrafast -async 1 {Path.Combine(VideoTools.vidFolderPath, i + ".mp4")}");

                VideoTools.RunFfmpeg($"-y -i {Path.Combine(VideoTools.vidFolderPath, i + ".mp4")} -itsoffset {position} -i {Path.Combine(VideoTools.ttsFolderPath, i + ".wav")} -map 0:0 -map 1:0 -c:v copy -preset ultrafast -async 1 {Path.Combine(VideoTools.vidFolderPath, i + "a.mp4")}");
                VideoTools.RunFfmpeg($"-y -i {Path.Combine(VideoTools.vidFolderPath, i + "a.mp4")} {Path.Combine(VideoTools.vidFolderPath, i + ".wav")}");

                position += seconds[i];
            }
            

            
            string inputs = "";
            for (int i = 0; i < seconds.Count; i++)
            {
                inputs += $"-i {Path.Combine(VideoTools.vidFolderPath, i + ".wav")} ";
            }
            VideoTools.RunFfmpeg($"-y " + inputs + $"-filter_complex amix=inputs={seconds.Count}:duration=longest,volume={seconds.Count},dynaudnorm {Path.Combine(VideoTools.vidFolderPath, "finish.wav")}");

            VideoTools.RunFfmpeg($"-y -i {Path.Combine(VideoTools.vidFolderPath, $"{seconds.Count-1}.mp4")} -i {Path.Combine(VideoTools.vidFolderPath, "finish.wav")} -map 0:0 -map 1:0 -c:v copy -preset ultrafast finishedvideo.mp4");
            
            */
            comment = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comment++;
            pictureBox1.Image = ImageTools.CommentImage(post.comments[comment]);
        }
    }
}
