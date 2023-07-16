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
    public class adminCategoryController : Controller
    {
        categoryManager category = new categoryManager(new EfCategoryDal());
        // GET: adminCategory
        public ActionResult Index()
        {
            var values = category.listing();
            return View(values);
        }
        [HttpGet]
        public ActionResult addCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addCategory(category p)
        {
            categoryValidation categoryValidation = new categoryValidation();
            ValidationResult result = categoryValidation.Validate(p);
            if (result.IsValid)
            {
                category.addCategory(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            // category.addCategory(p);
            return View();
        }

        [HttpGet]
        public ActionResult editCategory(int Id)
        {
            var value = category.getId(Id);
            return View(value);
        }

        [HttpPost]
        public ActionResult editCategory(category p)
        {
            categoryValidation categoryValidation = new categoryValidation();
            ValidationResult result = categoryValidation.Validate(p);
            if (result.IsValid)
            {
                category.addCategory(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
           // category.updateCategory(p);
            return View();
        }

        public ActionResult deleteCategory(int Id )
        {
            var value = category.getId(Id);
            category.deleteCategory(value);
            return RedirectToAction("Index");
        }
    }
}