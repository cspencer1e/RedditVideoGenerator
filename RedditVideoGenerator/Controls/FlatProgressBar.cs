using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditVideoGenerator.Controls
{
    public class FlatProgressBar : ProgressBar
    {
        public FlatProgressBar()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void Dispose(bool disposing)
        {
            backBrush.Dispose();
            frontBrush.Dispose();
            base.Dispose(disposing);
        }

        Brush backBrush;
        Brush frontBrush;

        protected override void OnPaint(PaintEventArgs e)
        {
            if (backBrush==null)
            {
                backBrush = new SolidBrush(BackColor);
                frontBrush = new SolidBrush(ForeColor);
            }

            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum));
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            e.Graphics.FillRectangle(backBrush, 0, 0, e.ClipRectangle.Width, e.ClipRectangle.Height);
            e.Graphics.FillRectangle(frontBrush, 4, 4, rec.Width-8, rec.Height-8);
        }
    }
}
