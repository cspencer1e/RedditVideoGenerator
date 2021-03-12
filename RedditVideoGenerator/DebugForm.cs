using RedditSharp.Things;
using RedditVideoGenerator.Models;
using RedditVideoGenerator.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RedditVideoGenerator
{
    public partial class DebugForm : Form
    {
        RedditPost post;
        int comment = -1;

        public DebugForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            post = RedditTools.GetPost("AskReddit", FromTime.Day, 10, 10);
            pictureBox1.Image = ImageTools.PostImage(post);
            comment = -1;
            //pictureBox1.Image = ImageTools.CommentImage("According to my wife I cannot open the living room curtains properly and she always need to redo it", "chillipotpeeps", ImageTools.FormatScore(3481));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comment++;
            pictureBox1.Image = ImageTools.CommentImage(post.comments[comment]);
        }
    }
}
