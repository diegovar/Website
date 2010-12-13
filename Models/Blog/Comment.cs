using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models.Blog
{
    public class Comment
    {
        public string Id { get; set; }
        public string PosterId { get; set; }
        public string PosterName { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}