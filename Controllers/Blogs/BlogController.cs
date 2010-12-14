using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models.Blog;
using Website.Models.Music;

namespace Website.Controllers.Blogs
{
    public partial class BlogController : Controller
    {
        //
        // GET: /Blog/

        public virtual ActionResult Index(string blogName)
        {
            var b = new Blog
            {
                Name = blogName,
                Posts = new List<Post>
                {
                    new Post
                    {
                        Name = "Primer post!",
                        Date = DateTime.Now,
                        Content = "OMG <strong>Some tags work</strong> I might be able to link to <a href='http://www.google.com'>Google</a>",
                        Tags = new List<string>
                        {
                            "primer-post",
                            "hola"
                        },
                        Tracks = new List<Track>
                        {
                            new Track
                            {
                                Id = "0",
                                ArtistName = "Daft Punk",
                                Name = "Derezzed",
                                Url = Links.Content.sounds.Daft_Punk___Derezzed_mp3
                            }
                        },
                        Comments = new List<Comment>
                        {
                            new Comment
                            {
                                Id = "2", Email = "buenas@gmail.com", PosterId = "5", PosterName = "Juan de los palotes", Text = "This seems to be working\r and even <b>tags</b> don't work"
                            }
                        }
                    }
                }
            };
            return View(b);
        }

        public virtual ActionResult Tag(string blogName, string tag)
        {
            return View("Index");
        }

    }
}
