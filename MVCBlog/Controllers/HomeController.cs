using MVCBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlog.Controllers
{
    [ValidateInput(false)]
    public class HomeController : Controller
    {      
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {            
            var post = db.Posts.OrderByDescending(p => p.Date).Include(p => p.Author).Take(5);            
            return View(post.ToList());
        }
    
    }
}