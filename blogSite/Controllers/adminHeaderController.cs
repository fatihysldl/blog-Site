using BusinessLayer.concrete;
using BusinessLayer.validation;
using DataAccessLayer.EntityFramework;
using entityLayer.concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blogSite.Controllers
{
    public class adminHeaderController : Controller
    {
        headerManager header = new headerManager(new EfHeaderDal());
        // GET: adminHeader
        public ActionResult Index()
        {
            var values = header.listing();
            return View(values);
        }
        [HttpGet]
        public ActionResult editHeader(int Id)
        {
            var value = header.getId(Id);
            return View(value);
        }
        [HttpPost]
        public ActionResult editHeader(header p)
        {
            //header.updateHeader(p);
            headerValidation headerValidation = new headerValidation();
            ValidationResult result = headerValidation.Validate(p);
            if (result.IsValid)
            {
                header.updateHeader(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult deleteHeader(int Id)
        {
            var value = header.getId(Id);
            header.deleteHeader(value);
            return RedirectToAction("Index");
        }
    }
}