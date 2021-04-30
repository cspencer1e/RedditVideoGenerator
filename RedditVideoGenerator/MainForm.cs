using RedditSharp.Things;
using RedditVideoGenerator.Models;
using RedditVideoGenerator.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditVideoGenerator
{
    public partial class MainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public readonly Dictionary<string, Color> colorPalette = new Dictionary<string, Color>()
        {
            { "dark", Color.FromArgb(31,24,40) },
            { "panel", Color.FromArgb(28,32,71) },
            { "panel2", Color.FromArgb(20,40,102) },
            { "highlight", Color.FromArgb(43,90,165) },
            { "bright", Color.FromArgb(87,187,249) },
            { "ultrabright", Color.FromArgb(158,239,247) },
        };

        public Button selectedButton;
        public Panel selectedPanel;

        RedditPost selectedPost = null;

        public float targetBarValue = 100;
        public string statusText;
        float realBarValue = 100f;

        string consoleText;
        bool exceptionLogged;

        public MainForm()
        {
            InitializeComponent();

            selectedButton = postOptionsButton;
            selectedPanel = postOptionsPanel;

            postDateBox.SelectedIndex = 3;

            ttsVoiceBox.Items.AddRange(TTSTools.Speech.GetInstalledVoices().Select(voice => voice.VoiceInfo.Name).ToArray());
            ttsVoiceBox.SelectedIndex = 0;

            speedBox.SelectedIndex = 1;
        }

        public void Log(object message)
        {
            consoleText += $"[{DateTime.Now.ToString("T", CultureInfo.CreateSpecificCulture("en-us"))}] {message}\r\n";
        }

        public void LogException(object message)
        {
            consoleText += $"\r\n[{DateTime.Now.ToString("T", CultureInfo.CreateSpecificCulture("en-us"))}] An exception occurred! Please create an issue at https://github.com/cspencer1e/RedditVideoGenerator/issues with the below error message.\r\n\r\n{message}\r\n\r\n";
            exceptionLogged = true;
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();

            Invoke((MethodInvoker)(() => HandleProgressBar()));
        }

        async Task HandleProgressBar()
        {
            while (true)
            {
                if (targetBarValue > 100f) targetBarValue = 100f;
                progressBar.StatusMessage = statusText;
                realBarValue += (targetBarValue - realBarValue) * 0.09f;
                progressBar.Value = (int)(realBarValue*1000f);

                if (!string.IsNullOrEmpty(consoleText))
                {
                    consoleBox.AppendText(consoleText);
                    consoleText = "";
                }
                if (exceptionLogged)
                {
                    SwitchTab(generationButton, generationPanel);
                    exceptionLogged = false;
                }

                await Task.Delay(1);
            }
        }

        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SwitchTab(Button clickedButton, Panel targetPanel)
        {
            if (selectedButton == clickedButton) return;

            //selectedPanel.Enabled = false;
            selectedPanel.Visible = false;

            selectedPanel = targetPanel;

            //selectedPanel.Enabled = true;
            selectedPanel.Visible = true;

            selectedButton.BackColor = colorPalette["panel2"];
            selectedButton.ForeColor = colorPalette["bright"];
            selectedButton.Parent.BackColor = colorPalette["panel"];

            selectedButton = clickedButton;

            selectedButton.BackColor = colorPalette["highlight"];
            selectedButton.ForeColor = colorPalette["ultrabright"];
            selectedButton.Parent.BackColor = colorPalette["bright"];
        }

        private void postOptionsButton_Click(object sender, EventArgs e)
        {
            SwitchTab(postOptionsButton, postOptionsPanel);
        }

        private void videoOptionsButton_Click(object sender, EventArgs e)
        {
            SwitchTab(videoOptionsButton, videoOptionsPanel);
        }

        private void generationButton_Click(object sender, EventArgs e)
        {
            SwitchTab(generationButton, generationPanel);
        }

        private void helpTooltip_Draw(object sender, DrawToolTipEventArgs e)
        {
            Brush b = new SolidBrush(helpTooltip.ForeColor);
            e.DrawBackground();
            e.Graphics.DrawString(e.ToolTipText, SystemFonts.DefaultFont, b, e.Bounds, new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });
        }

        async Task SelectNewPost(bool clearPost = false, float multi = 1f)
        {
            if (clearPost == true)
            {
                selectedPost = null;
            }
            else
            {
                var sub = subredditBox.Text;
                var fromTime = postDateBox.Items[postDateBox.SelectedIndex].ToString();
                var commentAmt = (int)commentAmountBox.Value;
                var postDepth = (int)postDepthBox.Value;
                var postUrl = postUrlBox.Text;

                selectedPost = await Task.Run(() =>
                {
                    try
                    {
                        return RedditTools.GetPost(sub, (FromTime)Enum.Parse(typeof(FromTime), fromTime), commentAmt, postDepth, postUrl, multi, 1f);
                    }
                    catch (Exception ex)
                    {
                        Program.form.LogException(ex);
                        return null;
                    }
                });
            }

            var title = "None";
            var comments = "None";

            if (selectedPost != null)
            {
                title = selectedPost.title;
                comments = selectedPost.comments.Length.ToString();
            }

            selectedPostText.Text = "Selected Post: " + title;
            commentsText.Text = "Comments: " + comments;

            helpTooltip.SetToolTip(selectedPostText, title == "None" ? "" : title);
            helpTooltip.SetToolTip(commentsText, comments == "None" ? "" : string.Join("\n", selectedPost.comments.Select(c => c.content)));

            commentsText.Location = new Point(commentsText.Location.X, selectedPostText.Location.Y + selectedPostText.Size.Height);
        }

        private async void selectPostButton_Click(object sender, EventArgs e)
        {
            ChangeOptionsEnabled(false);
            await SelectNewPost();
            ChangeOptionsEnabled(true);
        }

        private async void clearButton_Click(object sender, EventArgs e)
        {
            await SelectNewPost(true);
        }

        void ChangeOptionsEnabled(bool enabled)
        {
            postOptionsPanel.Enabled = enabled;
            videoOptionsPanel.Enabled = enabled;
            generateVideoButton.Enabled = enabled;
        }

        private void backgroundVideoSelector_Click(object sender, EventArgs e)
        {
            if (backgroundVideoDialog.ShowDialog() == DialogResult.OK)
            {
                backgroundVideoBox.Text = backgroundVideoDialog.FileName;
            }
        }

        private void videoOutputSelector_Click(object sender, EventArgs e)
        {
            if (videoOutputDialog.ShowDialog() == DialogResult.OK)
            {
                videoOutputBox.Text = videoOutputDialog.FileName;
            }
        }

        private async void generateVideoButton_Click(object sender, EventArgs e)
        {
            string bgVideo = backgroundVideoBox.Text;
            string bgAudio = backgroundMusicBox.Text;
            string outVideo = videoOutputBox.Text;
            string vidPreset = speedBox.SelectedItem.ToString().ToLower();
            int resW = (int)resolutionXBox.Value;
            int resH = (int)resolutionYBox.Value;
            int bitrate = (int)bitrateBox.Value;
            
            if (!File.Exists(bgVideo) || Path.GetExtension(bgVideo) != ".mp4")
            {
                bgVideo = "default_bg.mp4";
            }

            if (!File.Exists(bgAudio) || Path.GetExtension(bgAudio) != ".mp3")
            {
                bgAudio = "default_bg.mp3";
            }

            bool outputValid = false;
            try
            {
                if (Directory.Exists(Path.GetDirectoryName(Path.GetFullPath(outVideo))) && Path.GetExtension(outVideo) == ".mp4")
                {
                    outputValid = true;
                }
            } catch { Program.form.LogException("a"); }

            //Program.form.Log(outputValid + " | " + Path.GetFullPath(outVideo) + " | " + Path.GetExtension(outVideo));

            if ((!File.Exists(bgVideo)) || (!File.Exists(bgAudio)) || !outputValid)
            {
                Program.form.LogException($"Invalid generation settings!\r\nRelevant generation settings listed below:\r\n\r\nBG Video: {bgVideo}\r\nBG Music: {bgAudio}\r\nOutput Video: {outVideo}\r\n\r\nNote that background video must be an .mp4 file, background music must be a .mp3 file, and output video must be in a folder that exists and be an .mp4 file.");
                return;
            }

            targetBarValue = 1f;
            float barMulti = 1f;
            if (selectedPost == null)
            {
                await SelectNewPost(false, 0.1f);
                barMulti = 0.9f;
            }
            if (selectedPost == null)
            {
                Program.form.Log($"Generation stopped due to the selected post being null.");
                return;
            }

            string voice = ttsVoiceBox.SelectedItem.ToString();
            int rate = (int)ttsSpeedBox.Value;

            await Task.Run(() =>
            {
                try
                {
                    VideoTools.CleanupTempFolders();
                    ImageTools.GeneratePostImages(selectedPost, barMulti*0.05f, Program.form.targetBarValue);
                    TTSTools.SpeakPost(selectedPost, voice, rate, barMulti*0.1f, Program.form.targetBarValue);
                    VideoTools.GenerateVideo(bgVideo, bgAudio, outVideo, vidPreset, resW, resH, bitrate);
                    VideoTools.CleanupTempFolders();
                }
                catch (Exception ex)
                {
                    Program.form.LogException(ex);
                }
            });
        }
    }
}
