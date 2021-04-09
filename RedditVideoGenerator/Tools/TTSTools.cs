using NAudio.Wave;
using RedditVideoGenerator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace RedditVideoGenerator.Tools
{
    public static class TTSTools
    {
        static SpeechSynthesizer speech = null;
        public static SpeechSynthesizer Speech { get
            {
                if (speech==null)
                {
                    speech = new SpeechSynthesizer();
                    speech.Rate = 2;
                }
                return speech;
            }
        }

        public static MemoryStream Speak(string text)
        {
            var ret = new MemoryStream();
            Speech.SetOutputToWaveStream(ret);
            Speech.Speak(text);
            return ret;
        }

        public static void SpeakPost(RedditPost post)
        {
            VideoTools.SetupTempFolders();
            List<string> text = new List<string>();
            text.Add(ImageTools.CleanText(post.title)+".\n.\n.\n"+ImageTools.CleanText(!post.isImage ? post.content : ""));
            //if (!post.isImage) text.Add(post.content);
            foreach (var comment in post.comments)
            {
                text.Add(ImageTools.CleanText(comment.content));
            }
            List<int> lengths = new List<int>();
            for (int i=0;i<text.Count;i++)
            {
                var speech = Speak(text[i]);
                speech.Position = 0;
                File.WriteAllBytes(Path.Combine(VideoTools.ttsFolderPath, i + ".wav"), speech.ToArray());
                lengths.Add((int)Math.Ceiling(new WaveFileReader(speech).TotalTime.TotalSeconds + 1f));
            }
            File.WriteAllText(Path.Combine(VideoTools.tempFolderName, "ttsLengths.txt"), string.Join(",",lengths));
        }
    }
}
