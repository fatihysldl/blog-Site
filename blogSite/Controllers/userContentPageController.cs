using BusinessLayer.concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blogSite.Controllers
{
    public class userContentPageController : Controller
    {
        // GET: userContentPage
        postManager posts = new postManager(new EfPostDal());
        public ActionResult Index(int Id)
        {
            var value = posts.List(x=>x.postId==Id);
            return View(value);
        }
    }
}