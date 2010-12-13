using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models.Blog;

namespace Website.Controllers
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
                        Tags = new List<string>
                        {
                            "primer-post", "hola"
                        },
                        Comments = new List<Comment>
                        {
                            new Comment
                            {
                                Id = "2", Email = "buenas@gmail.com", PosterId = "5", PosterName = "Juan de los palotes", Text = "This seems to be working\r and even <b>some tags</b> work"
                            }
                        }
                    }
                }
            };
            return View(b);
        }

        public virtual ActionResult Post(string id)
        {
            return View("Index");
        }

        public virtual ActionResult Tag(string blogName, string tag)
        {
            return View("Index");
        }

    }
}
