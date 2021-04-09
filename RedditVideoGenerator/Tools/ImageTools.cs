using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using RedditVideoGenerator.Models;
using System.Net;
using System.Drawing.Drawing2D;

namespace RedditVideoGenerator.Tools
{
    public static class ImageTools
    {
        public static float scale = 1.334375f;

        public static void GeneratePostImages(RedditPost post)
        {
            VideoTools.SetupTempFolders();
            PostImage(post).Save(Path.Combine(VideoTools.imgFolderPath, "0.png"));
            for (int i = 1; i <= post.comments.Length; i++)
            {
                CommentImage(post.comments[i - 1]).Save(Path.Combine(VideoTools.imgFolderPath, i+".png"));
            }
        }

        public static Bitmap PostImage(RedditPost post)
        {
            return PostImage(CleanText(post.title), CleanText(post.content), post.author, FormatScore(post.score));
        }

        public static Bitmap PostImage(string title, string content, string author, string score)
        {
            int canvasWidth = (int)(640 * scale);
            int canvasHeight = (int)(6 * scale);

            Graphics fontGraphics = Graphics.FromImage(new Bitmap(1, 1));
            Font titleFont = new Font("IBM Plex Sans", 14.85f * scale, FontStyle.Regular);
            Font scoreFont = new Font("IBM Plex Sans", 8.8f * scale, FontStyle.Bold);
            Font userFont = new Font("IBM Plex Sans", 8.75f * scale, FontStyle.Regular);
            Font bodyFont = new Font("IBM Plex Sans", 10.7f * scale, FontStyle.Regular);

            Brush backgroundBrush = new SolidBrush(Color.FromArgb(26, 26, 27));
            Brush userBrush = new SolidBrush(Color.FromArgb(129,131,132));
            Brush textBrush = new SolidBrush(Color.FromArgb(215,218,220));

            Bitmap scoreTemplate = new Bitmap("ScoreTemplate.png");
            scoreTemplate = (Bitmap)ResizeImageKeepAspectRatio(scoreTemplate, (int)(scoreTemplate.Width * scale), (int)(scoreTemplate.Height * scale));

            var userSize = fontGraphics.MeasureString("Posted by u/" + author, userFont);
            var titleSize = fontGraphics.MeasureString(title, titleFont, canvasWidth - (int)(52 * scale));
            var bodySize = fontGraphics.MeasureString(content, bodyFont, canvasWidth - (int)(52 * scale));

            Image postImage = null;
            if (content.Contains("i.redd.it"))
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(content);
                MemoryStream ms = new MemoryStream(bytes);
                postImage = ResizeImageKeepAspectRatio(Image.FromStream(ms), canvasWidth-(int)(57 * scale), (int)(515 * scale));

                bodySize = postImage.Size;
                //bodySize = new SizeF(postImage.Size.Width, 515);
            }

            canvasHeight += (int)userSize.Height + (int)(13 * scale);
            canvasHeight += (int)titleSize.Height + (int)bodySize.Height + (int)(13 * scale);

            if (scoreTemplate.Height > canvasHeight) canvasHeight = scoreTemplate.Height;

            Bitmap canvas = new Bitmap(canvasWidth, canvasHeight);
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                
                g.FillRectangle(backgroundBrush, 0, 0, canvasWidth, canvasHeight);

                g.DrawImage(scoreTemplate, 0, 0);

                g.DrawString("Posted by u/" + author, userFont, userBrush, new Point((int)(47 * scale), (int)(5 * scale)));

                g.DrawString(title, titleFont, textBrush, new RectangleF(47 * scale, 27 * scale, canvasWidth-(52 * scale), 1000f * scale));
                g.DrawString(title, titleFont, textBrush, new RectangleF(46 * scale, 27 * scale, canvasWidth - (52 * scale), 1000f * scale));

                if (postImage == null)
                {
                    g.DrawString(content, bodyFont, textBrush, new RectangleF(47 * scale, (35 * scale) + titleSize.Height, canvasWidth - (52 * scale), 1000f * scale));
                    g.DrawString(content, bodyFont, textBrush, new RectangleF(46.75f * scale, (35 * scale) + titleSize.Height, canvasWidth - (52 * scale), 1000f * scale));
                }
                else
                {
                    //g.DrawImage(postImage, new RectangleF(47, 35 + titleSize.Height, canvasWidth - 57, 515));
                    g.DrawImage(postImage, new PointF(47f * scale, (35 * scale) + titleSize.Height));
                }

                g.DrawString(score, scoreFont, textBrush, new RectangleF(0, 0, 42 * scale, 66 * scale), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center, Trimming = StringTrimming.None});
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
            int canvasWidth = (int)(640 * scale);
            int canvasHeight = (int)(6 * scale);

            Graphics fontGraphics = Graphics.FromImage(new Bitmap(1, 1));
            Font titleFont = new Font("IBM Plex Sans", 14.85f * scale, FontStyle.Regular);
            Font scoreFont = new Font("IBM Plex Sans", 8.8f * scale, FontStyle.Bold);
            Font userFont = new Font("IBM Plex Sans", 8.75f * scale, FontStyle.Regular);
            Font bodyFont = new Font("IBM Plex Sans", 10.7f * scale, FontStyle.Regular);

            Brush backgroundBrush = new SolidBrush(Color.FromArgb(26, 26, 27));
            Brush userBrush = new SolidBrush(Color.FromArgb(129, 131, 132));
            Brush textBrush = new SolidBrush(Color.FromArgb(215, 218, 220));

            var userSize = fontGraphics.MeasureString(author, userFont);
            var bodySize = fontGraphics.MeasureString(content, bodyFont, canvasWidth - (int)(52 * scale));

            canvasHeight += (int)userSize.Height + (int)(13 * scale);
            canvasHeight += (int)bodySize.Height;

            Bitmap canvas = new Bitmap(canvasWidth, canvasHeight);
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                g.FillRectangle(backgroundBrush, 0, 0, canvasWidth, canvasHeight);

                g.DrawString(author, userFont, textBrush, new PointF(5 * scale, 5 * scale));
                g.DrawString(score+" points", userFont, userBrush, new PointF((8 * scale) + (int)userSize.Width, 5 * scale));

                g.DrawString(content, bodyFont, textBrush, new RectangleF(5 * scale, 25 * scale, canvasWidth - (10 * scale), 1000f * scale));
                g.DrawString(content, bodyFont, textBrush, new RectangleF(4.75f * scale, 25 * scale, canvasWidth - (10 * scale), 1000f * scale));

                
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

        public static Image ResizeImageKeepAspectRatio(Image source, int width, int height)
        {
            Image result = null;

            try
            {
                if (source.Width != width || source.Height != height)
                {
                    // Resize image
                    float sourceRatio = (float)source.Width / source.Height;

                    using (var target = new Bitmap(width, height))
                    {
                        using (var g = System.Drawing.Graphics.FromImage(target))
                        {
                            g.CompositingQuality = CompositingQuality.HighQuality;
                            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            g.SmoothingMode = SmoothingMode.HighQuality;

                            // Scaling
                            float scaling;
                            float scalingY = (float)source.Height / height;
                            float scalingX = (float)source.Width / width;
                            if (scalingX < scalingY) scaling = scalingX; else scaling = scalingY;

                            int newWidth = (int)(source.Width / scaling);
                            int newHeight = (int)(source.Height / scaling);

                            // Correct float to int rounding
                            if (newWidth < width) newWidth = width;
                            if (newHeight < height) newHeight = height;

                            // See if image needs to be cropped
                            int shiftX = 0;
                            int shiftY = 0;

                            if (newWidth > width)
                            {
                                shiftX = (newWidth - width) / 2;
                            }

                            if (newHeight > height)
                            {
                                shiftY = (newHeight - height) / 2;
                            }

                            // Draw image
                            g.DrawImage(source, -shiftX, -shiftY, newWidth, newHeight);
                        }

                        result = new Bitmap(target);
                    }
                }
                else
                {
                    // Image size matched the given size
                    result = new Bitmap(source);
                }
            }
            catch (Exception)
            {
                result = null;
            }

            return result;
        }
    }
}
