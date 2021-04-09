using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditVideoGenerator.Controls
{
    public class FlatComboBox : ComboBox
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

        public FlatComboBox()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case 0xf:
                    //Paint the background. Only the borders
                    //will show up because the edit
                    //box will be overlayed
                    Graphics g = this.CreateGraphics();
                    //Pen p = new Pen(Color.White, 2);
                    g.FillRectangle(BorderBrush, this.ClientRectangle);

                    //Draw the background of the dropdown button
                    Rectangle rect = new Rectangle(this.Width - 15, 3, 12, this.Height - 6);
                    g.FillRectangle(DropButtonBrush, rect);

                    //Create the path for the arrow
                    System.Drawing.Drawing2D.GraphicsPath pth = new System.Drawing.Drawing2D.GraphicsPath();
                    PointF TopLeft = new PointF(this.Width - 13, (this.Height - 5) / 2);
                    PointF TopRight = new PointF(this.Width - 6, (this.Height - 5) / 2);
                    PointF Bottom = new PointF(this.Width - 9, (this.Height + 2) / 2);
                    pth.AddLine(TopLeft, TopRight);
                    pth.AddLine(TopRight, Bottom);

                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                    ArrowBrush = new SolidBrush(ForeColor);

                    //Draw the arrow
                    g.FillPath(ArrowBrush, pth);

                    if (Items.Count > 0)
                    {
                        int index = SelectedIndex >= 0 ? SelectedIndex : 0;
                        g.DrawString(Items[index].ToString(), Font, ArrowBrush, 2f, 5f);
                    }

                    break;
                default:
                    break; // TODO: might not be correct. Was : Exit Select
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = new SolidBrush(e.ForeColor);
            var brush2 = new SolidBrush(e.BackColor);

            if (e.State.HasFlag(DrawItemState.Focus) || e.State.HasFlag(DrawItemState.Selected))
            {
                brush2 = DropButtonBrush;
            }
            e.Graphics.FillRectangle(brush2, e.Bounds);
            if (index < Items.Count) e.Graphics.DrawString(Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
        }
    }
}
