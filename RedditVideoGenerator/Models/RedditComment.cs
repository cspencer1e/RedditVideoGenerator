using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedditVideoGenerator.Models
{
    public class RedditComment
    {
        public string content, author;
        public int score;

        // TODO: Add image and speech fields

        public RedditComment() { }

        public RedditComment(string _content, string _author, int _score)
        {
            content = _content;
            author = _author;
            score = _score;
        }
    }
}
