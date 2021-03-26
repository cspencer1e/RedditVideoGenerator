using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditVideoGenerator.Controls
{
    public class FlatNumericUpDown : NumericUpDown
    {
        private Brush BorderBrush = new SolidBrush(SystemColors.Window);
        private Brush ArrowBrush = new SolidBrush(SystemColors.ControlText);
        private SolidBrush DropButtonBrush = new SolidBrush(SystemColors.Control);

        private Color _ButtonColor = SystemColors.Control;
        public Color ButtonColor
        {
            get { return _ButtonColor; }
            set
            {
                _ButtonColor = value;
                DropButtonBrush = new SolidBrush(this.ButtonColor);
                BorderBrush = new SolidBrush(BackColor);
                ArrowBrush = new SolidBrush(ForeColor);
                this.Invalidate();
            }
        }

        public FlatNumericUpDown()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            Controls[1].Visible = false;

            Controls[0].Paint += UpDownArrowPaint;
            typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null,Controls[0], new object[] { true });

            Controls.Add(new Label { Location = new Point(0, 0), Size = Controls[1].Size, TextAlign = ContentAlignment.MiddleLeft, Text = ((int)Value).ToString() });
            //Controls.RemoveAt(1);

            //Controls[1].Paint += TextboxPaint;
            //typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, Controls[1], new object[] { true });

        }

        private void TextboxPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);

        }

        protected override void OnValueChanged(EventArgs e)
        {
            base.OnValueChanged(e);
            try
            { (Controls[2] as Label).Text = ((int)Value).ToString(); }
            catch { }
        }

        private void UpDownArrowPaint(object sender, PaintEventArgs e)
        {
            //Debug.WriteLine("Here");
            //e.Graphics.DrawString(((int)Value).ToString(), Font, ArrowBrush, 2f, 0f);

            int h = Controls[0].Height;
            int w = Controls[0].Width;
            e.Graphics.Clear(BackColor);

            e.Graphics.FillRectangle(DropButtonBrush, 1, 3, w - 4, (h / 2) - 4);
            e.Graphics.FillRectangle(DropButtonBrush, 1, (h / 2) + 2, w - 4, (h / 2) - 4);

            System.Drawing.Drawing2D.GraphicsPath downArrow = new System.Drawing.Drawing2D.GraphicsPath();
            PointF TopLeft = new PointF(w - 13, (h - 5 + 12) / 2);
            PointF TopRight = new PointF(w - 6, (h - 5 + 12) / 2);
            PointF Bottom = new PointF(w - 9, (h + 2 + 12) / 2);
            downArrow.AddLine(TopLeft, TopRight);
            downArrow.AddLine(TopRight, Bottom);

            System.Drawing.Drawing2D.GraphicsPath upArrow = new System.Drawing.Drawing2D.GraphicsPath();
            TopLeft = new PointF(w - 13, (h + 2 - 12) / 2);
            TopRight = new PointF(w - 6, (h + 2 - 12) / 2);
            Bottom = new PointF(w - 9, (h - 5 - 12) / 2);
            upArrow.AddLine(TopLeft, TopRight);
            upArrow.AddLine(TopRight, Bottom);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            ArrowBrush = new SolidBrush(ForeColor);

            //Draw the arrows
            e.Graphics.FillPath(ArrowBrush, downArrow);
            e.Graphics.FillPath(ArrowBrush, upArrow);
        }

        
        /*
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case 0xf:
                    Debug.WriteLine("a");
                    Graphics g = this.CreateGraphics();
                    //g.DrawString(((int)Value).ToString(), Font, ArrowBrush, 2f, 0f);

                    break;
                default:
                    break; // TODO: might not be correct. Was : Exit Select
            }
        }

        
        protected override void OnPaint(PaintEventArgs e)
        {
            Debug.WriteLine("b");

            //base.OnPaint(e);

            //Paint the background. Only the borders
            //will show up because the edit
            //box will be overlayed
            //Graphics g = this.CreateGraphics();
            //Pen p = new Pen(Color.White, 2);
            //e.Graphics.FillRectangle(BorderBrush, this.ClientRectangle);



            //int index = SelectedIndex >= 0 ? SelectedIndex : 0;
            //g.DrawString(Items[index].ToString(), Font, ArrowBrush, 2f, 5f);
        }
        */
    }
}
