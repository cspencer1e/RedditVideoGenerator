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

        public static void SpeakPost(RedditPost post, string voice, int rate, float multi = 1f, float barStartPos = 0f)
        {
            VideoTools.SetupTempFolders();

            Program.form.Log($"Setting up speech options...");

            Speech.SelectVoice(voice);
            Speech.Rate = rate;

            Program.form.Log($"Formatting speech text...");
            List<string> text = new List<string>();
            text.Add(ImageTools.CleanText(post.title)+".\n.\n.\n"+ImageTools.CleanText(!post.isImage ? post.content : ""));
            foreach (var comment in post.comments)
            {
                text.Add(ImageTools.CleanText(comment.content));
            }
            
            Program.form.targetBarValue = barStartPos;
            Program.form.statusText = "Generating text to speech...";
            Program.form.Log($"Beginning speech generation...");

            float inc = 100f / text.Count;
            List<int> lengths = new List<int>();
            for (int i=0;i<text.Count;i++)
            {
                Program.form.targetBarValue = barStartPos + (inc * i) * multi;
                Program.form.statusText = $"Generating speech {i}...";
                Program.form.Log($"Generating speech {i}...");

                var speech = Speak(text[i]);
                speech.Position = 0;
                File.WriteAllBytes(Path.Combine(VideoTools.ttsFolderPath, i + ".wav"), speech.ToArray());
                lengths.Add((int)Math.Ceiling(new WaveFileReader(speech).TotalTime.TotalSeconds + 1f));
            }
            File.WriteAllText(Path.Combine(VideoTools.tempFolderName, "ttsLengths.txt"), string.Join(",",lengths));

            Program.form.targetBarValue = barStartPos + 100f * multi;
            Program.form.statusText = "";
            Program.form.Log($"Successfully finished text to speech generation with {text.Count} voice lines generated.");
        }
    }
}
