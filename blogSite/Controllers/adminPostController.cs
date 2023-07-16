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
    public class adminPostController : Controller
    {
        postManager post = new postManager(new EfPostDal());
        authorManager author = new authorManager(new EfAuthorDal());
        categoryManager category = new categoryManager(new EfCategoryDal());
        // GET: adminPost
        public ActionResult Index()
        {
            var values = post.listing();
            return View(values);
        }
        [HttpGet]
        public ActionResult addPost()
        {
            List<SelectListItem> authorValues = (from i in author.listing()
                                                 select new SelectListItem
                                                 {
                                                     Text = i.authorName,
                                                     Value = i.authorId.ToString()
                                                 }).ToList();
            ViewBag.authorValue = authorValues;

            List<SelectListItem> categoryValues = (from i in category.listing()
                                                 select new SelectListItem
                                                 {
                                                     Text = i.categoryName,
                                                     Value = i.categoryId.ToString()
                                                 }).ToList();
            ViewBag.categoryValue = categoryValues;
            return View();
        }
        [HttpPost]
        public ActionResult addPost(post p)
        {
            //post.AddPost(p);
            postValidation postValidation = new postValidation();
            ValidationResult results = postValidation.Validate(p);
            if (results.IsValid)
            {
                post.AddPost(p);
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
        [HttpGet]
        public ActionResult editPost(int Id)
        {
            var value = post.getId(Id);
            return View(value);
        }
        [HttpPost]
        public ActionResult editPost(post p)
        {
            //post.updatePost(p);
            postValidation postValidation = new postValidation();
            ValidationResult results = postValidation.Validate(p);
            if (results.IsValid)
            {
                post.AddPost(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return RedirectToAction("Index");
        }
        public ActionResult deletePost(int Id)
        {
            var value = post.getId(Id);
            post.postDelete(value);
            return RedirectToAction("Index");
        }
    }
}