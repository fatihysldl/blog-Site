using BusinessLayer.concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blogSite.Controllers
{
    public class userHomePageController : Controller
    {
        // GET: userHomePage
        postManager posts = new postManager(new EfPostDal());
        headerManager header = new headerManager(new EfHeaderDal());
        public ActionResult homePage()
        {
            
            return View();
        }

        public ActionResult post()
        {
            var values = posts.listing();
            return View(values);
        }
        public ActionResult homePageHeader()
        {
            var values = header.listing();
            return View(values);
        }
    }
}