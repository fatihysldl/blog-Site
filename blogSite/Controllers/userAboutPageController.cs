using BusinessLayer.concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blogSite.Controllers
{
    public class userAboutPageController : Controller
    {
        // GET: userAboutPage
        aboutManager about = new aboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var values = about.listing();
            return View(values);
        }
    }
}