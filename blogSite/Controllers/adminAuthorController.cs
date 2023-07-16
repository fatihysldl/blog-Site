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
    public class adminAuthorController : Controller
    {
        authorManager author = new authorManager(new EfAuthorDal());
        // GET: adminAuthor
        public ActionResult Index()
        {
            var values = author.listing();
            return View(values);
        }

        [HttpGet]
        public ActionResult addAuthor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addAuthor(author p)
        {
            authorValidation authorValidation = new authorValidation();
            ValidationResult results = authorValidation.Validate(p);
            if (results.IsValid)
            {
                author.addAuthor(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            // author.addAuthor(p);
            return View();
        }
        [HttpGet]
        public ActionResult editAuthor(int Id)
        {
            var value = author.getId(Id);
            return View(value);
        }
        [HttpPost]
        public ActionResult editAuthor(author p)
        {
            authorValidation authorValidation = new authorValidation();
            ValidationResult results = authorValidation.Validate(p);
            if (results.IsValid)
            {
                author.updateAuthor(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            // author.updateAuthor(p);
            return View();
        }
        public ActionResult deleteAuthor(int Id)
        {
            var value = author.getId(Id);
            author.deleteAuthor(value);
            return RedirectToAction("Index");
        }
    }
}