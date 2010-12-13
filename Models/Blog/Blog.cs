using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models.Blog
{
    public class Blog
    {
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
    }
}