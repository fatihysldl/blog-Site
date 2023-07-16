using BusinessLayer.concrete;
using BusinessLayer.validation;
using DataAccessLayer.EntityFramework;
using entityLayer.concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blogSite.Controllers
{
    public class adminAboutController : Controller
    {
        aboutManager about = new aboutManager(new EfAboutDal());
        // GET: adminAbout
        public ActionResult Index()
        {
            var values = about.listing();
            return View(values);
        }
        [HttpGet]
        public ActionResult editAbout(int Id)
        {
            var value = about.getId(Id);
            return View(value);
        }
        [HttpPost]
        public ActionResult editAbout(about p)
        {
            //about.updateAbout(p);
            aboutValidation aboutValidation = new aboutValidation();
            ValidationResult results = aboutValidation.Validate(p);
            if (results.IsValid)
            {
                about.updateAbout(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
               
            }
            return View();
        }
        public ActionResult deleteAbout(int Id)
        {
            var value = about.getId(Id);
            about.deleteAbout(value);
            return RedirectToAction("Index");
        }
    }
}