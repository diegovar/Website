using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website.Models.Music;

namespace Website.Models.Blog
{
    public class Post
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<string> Tags { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Track> Tracks { get; set; }
        public String Content { get; set; }
    }
}