using JSONWithAspNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JSONWithAspNetMVC.Controllers
{
    public class BlogsController : Controller
    {
        private BlogContext db = null;

        public BlogsController()
        {
            db = new Models.BlogContext();
        }
        // GET: Blogs
        public ActionResult Index()
        {
            ViewBag.CategoryId = new SelectList(db.Categories.OrderBy(c=>c.CategoryName), "CategoryId", "CategoryName");

            return View();
        }

        public JsonResult GetBlogDetailByCategory(int categoryId)
        {
            var blogs = db.BLog.Where(b=>b.CategoryId == categoryId).Take(5).ToList();

            return Json(blogs, JsonRequestBehavior.AllowGet);    
        }
    }
}