using RedditSharp.Things;
using RedditVideoGenerator.Models;
using RedditVideoGenerator.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

        public MainForm()
        {
            InitializeComponent();

            selectedButton = postOptionsButton;
            selectedPanel = postOptionsPanel;

            postDateBox.SelectedIndex = 3;

            ttsVoiceBox.Items.AddRange(TTSTools.Speech.GetInstalledVoices().Select(voice => voice.VoiceInfo.Name).ToArray());
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

        void UpdatePostBox(RedditPost newPost = null)
        {
            selectedPost = newPost;

            var title = "None";
            var comments = "None";

            if (newPost!=null)
            {
                title = newPost.title;
                comments = newPost.comments.Length.ToString();
            }

            selectedPostText.Text = "Selected Post: " + title;
            commentsText.Text = "Comments: " + comments;

            helpTooltip.SetToolTip(selectedPostText, title == "None" ? "" : title);
            helpTooltip.SetToolTip(commentsText, comments == "None" ? "" : string.Join("\n", newPost.comments.Select(c => c.content)));

            commentsText.Location = new Point(commentsText.Location.X, selectedPostText.Location.Y + selectedPostText.Size.Height);
        }

        private async void selectPostButton_Click(object sender, EventArgs e)
        {
            var sub = subredditBox.Text;
            var fromTime = postDateBox.Items[postDateBox.SelectedIndex].ToString();
            var commentAmt = (int)commentAmountBox.Value;
            var postDepth = (int)postDepthBox.Value;
            var postUrl = postUrlBox.Text;

            //backgroundWorker1.RunWorkerAsync(new object[]{ sub, fromTime, commentAmt, postDepth, postUrl });
            ChangeOptionsEnabled(false);
            var post = await Task.Run(() => RedditTools.GetPost(sub, (FromTime)Enum.Parse(typeof(FromTime), fromTime), commentAmt, postDepth, postUrl));
            ChangeOptionsEnabled(true);
            UpdatePostBox(post);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            UpdatePostBox(null);
        }

        void ChangeOptionsEnabled(bool enabled)
        {
            postOptionsPanel.Enabled = enabled;
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
    }
}
