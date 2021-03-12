using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedditVideoGenerator.Models
{
    public class RedditPost : RedditComment
    {
        public string title;
        public RedditComment[] comments;

        public RedditPost() { }

        public RedditPost(string _title, string _content, string _author, int _score, params RedditComment[] _comments) : base(_content, _author, _score)
        {
            title = _title;
            comments = _comments;
        }
    }
}
