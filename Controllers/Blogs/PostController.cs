using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models.Blog;

namespace Website.Controllers.Blogs
{
    public partial class PostController : Controller
    {
        //
        // GET: /Post/

        public virtual ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Post/Details/5

        public virtual ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Post/Create

        public virtual ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Post/Create

        [HttpPost]
        public virtual ActionResult Create(Post p)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Post/Edit/5

        public virtual ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Post/Edit/5

        [HttpPost]
        public virtual ActionResult Edit(int id, Post p)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Post/Delete/5

        public virtual ActionResult Delete(int id)
        {
            return View();
        }
    }
}
