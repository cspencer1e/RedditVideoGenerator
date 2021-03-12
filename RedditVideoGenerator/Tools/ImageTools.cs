using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using RedditVideoGenerator.Models;

namespace RedditVideoGenerator.Tools
{
    public static class ImageTools
    {
        public static Bitmap PostImage(RedditPost post)
        {
            return PostImage(CleanText(post.title), CleanText(post.content), post.author, FormatScore(post.score));
        }

        public static Bitmap PostImage(string title, string content, string author, string score)
        {
            int canvasWidth = 640;
            int canvasHeight = 6;

            Graphics fontGraphics = Graphics.FromImage(new Bitmap(1, 1));
            Font titleFont = new Font("IBM Plex Sans", 14.85f, FontStyle.Regular);
            Font scoreFont = new Font("IBM Plex Sans", 8.8f, FontStyle.Bold);
            Font userFont = new Font("IBM Plex Sans", 8.75f, FontStyle.Regular);
            Font bodyFont = new Font("IBM Plex Sans", 10.7f, FontStyle.Regular);

            Brush backgroundBrush = new SolidBrush(Color.FromArgb(26, 26, 27));
            Brush userBrush = new SolidBrush(Color.FromArgb(129,131,132));
            Brush textBrush = new SolidBrush(Color.FromArgb(215,218,220));

            Bitmap scoreTemplate = new Bitmap("ScoreTemplate.png");

            var userSize = fontGraphics.MeasureString("Posted by u/" + author, userFont);
            var titleSize = fontGraphics.MeasureString(title, titleFont, canvasWidth - 52);
            var bodySize = fontGraphics.MeasureString(content, bodyFont, canvasWidth - 52);

            canvasHeight += (int)userSize.Height + 13;
            canvasHeight += (int)titleSize.Height + (int)bodySize.Height + 13;

            if (scoreTemplate.Height > canvasHeight) canvasHeight = scoreTemplate.Height;

            Bitmap canvas = new Bitmap(canvasWidth, canvasHeight);
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                
                g.FillRectangle(backgroundBrush, 0, 0, canvasWidth, canvasHeight);

                g.DrawImage(scoreTemplate, 0, 0);

                g.DrawString("Posted by u/" + author, userFont, userBrush, new Point(47, 5));

                g.DrawString(title, titleFont, textBrush, new RectangleF(47,27,canvasWidth-52,1000f));
                g.DrawString(title, titleFont, textBrush, new RectangleF(46, 27, canvasWidth - 52, 1000f));

                g.DrawString(content, bodyFont, textBrush, new RectangleF(47, 35 + titleSize.Height, canvasWidth - 52, 1000f));
                g.DrawString(content, bodyFont, textBrush, new RectangleF(46.75f, 35 + titleSize.Height, canvasWidth - 52, 1000f));

                g.DrawString(score, scoreFont, textBrush, new RectangleF(0, 0, 42, 66), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center, Trimming = StringTrimming.None});
            }

            fontGraphics.Dispose();
            titleFont.Dispose();
            scoreFont.Dispose();
            userFont.Dispose();
            bodyFont.Dispose();

            backgroundBrush.Dispose();
            userBrush.Dispose();
            textBrush.Dispose();

            return canvas;
        }

        public static Bitmap CommentImage(RedditComment comment)
        {
            return CommentImage(CleanText(comment.content), comment.author, FormatScore(comment.score));
        }

        public static Bitmap CommentImage(string content, string author, string score)
        {
            int canvasWidth = 640;
            int canvasHeight = 6;

            Graphics fontGraphics = Graphics.FromImage(new Bitmap(1, 1));
            Font titleFont = new Font("IBM Plex Sans", 14.85f, FontStyle.Regular);
            Font scoreFont = new Font("IBM Plex Sans", 8.8f, FontStyle.Bold);
            Font userFont = new Font("IBM Plex Sans", 8.75f, FontStyle.Regular);
            Font bodyFont = new Font("IBM Plex Sans", 10.7f, FontStyle.Regular);

            Brush backgroundBrush = new SolidBrush(Color.FromArgb(26, 26, 27));
            Brush userBrush = new SolidBrush(Color.FromArgb(129, 131, 132));
            Brush textBrush = new SolidBrush(Color.FromArgb(215, 218, 220));

            var userSize = fontGraphics.MeasureString(author, userFont);
            var bodySize = fontGraphics.MeasureString(content, bodyFont, canvasWidth - 52);

            canvasHeight += (int)userSize.Height + 13;
            canvasHeight += (int)bodySize.Height;

            Bitmap canvas = new Bitmap(canvasWidth, canvasHeight);
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                g.FillRectangle(backgroundBrush, 0, 0, canvasWidth, canvasHeight);

                g.DrawString(author, userFont, textBrush, new Point(5, 5));
                g.DrawString(score+" points", userFont, userBrush, new Point(8 + (int)userSize.Width, 5));

                g.DrawString(content, bodyFont, textBrush, new RectangleF(5, 25, canvasWidth - 10, 1000f));
                g.DrawString(content, bodyFont, textBrush, new RectangleF(4.75f, 25, canvasWidth - 10, 1000f));

                
            }

            fontGraphics.Dispose();
            titleFont.Dispose();
            scoreFont.Dispose();
            userFont.Dispose();
            bodyFont.Dispose();

            backgroundBrush.Dispose();
            userBrush.Dispose();
            textBrush.Dispose();

            return canvas;
        }

        public static string FormatScore(int num)
        {
            if (num >= 100000)
                return FormatScore(num / 1000) + "k";
            if (num >= 1000)
            {
                return (num / 1000D).ToString("0.#") + "k";
            }
            return num.ToString("#,0");
        }

        public static string CleanText(string text)
        {
            return text.Replace("&gt;", "").Replace("&amp;#x200B", "").Replace("&amp;", "&");
        }
    }
}
