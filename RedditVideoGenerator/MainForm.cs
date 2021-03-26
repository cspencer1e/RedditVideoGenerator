using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();

            selectedButton = postOptionsButton;
            selectedPanel = postOptionsPanel;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            
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

            selectedPanel.Enabled = false;
            selectedPanel.Visible = false;

            selectedPanel = targetPanel;

            selectedPanel.Enabled = true;
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

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customComboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void helpTooltip_Draw(object sender, DrawToolTipEventArgs e)
        {
            Brush b = new SolidBrush(helpTooltip.ForeColor);
            e.DrawBackground();
            //e.DrawBorder();
            //e.DrawText();
            e.Graphics.DrawString(e.ToolTipText, SystemFonts.DefaultFont, b, e.Bounds, new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });
            //e.DrawText();
        }
    }
}
