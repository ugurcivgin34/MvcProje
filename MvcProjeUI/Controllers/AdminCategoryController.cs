using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUI.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        CategoryValidator categoryValidator = new CategoryValidator();
        // GET: AdminCategory
        public ActionResult Index()
        {
            var categoryValues = cm.List();

            return View(categoryValues);
        }

    
        [HttpGet]//Sayfa ilk yüklendiğinde alttaki metod çalışacak
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]//Butona tıklandığında alttaki metod çalışacak
        public ActionResult AddCategory(Category category)
        {
          
            ValidationResult results = categoryValidator.Validate(category);
            if (results.IsValid) //Geçerli ise
            {
                cm.CategoryAddBL(category);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            
        }

       
        public ActionResult DeleteCategory(int id)
        {
            var cetegoryValue = cm.GetById(id);
            cm.Delete(cetegoryValue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var categoryValues = cm.GetById(id);
            return View(categoryValues);
        }

        [HttpPost]
        public ActionResult EditCategory(Category category)
        {
            cm.CategoryUpdate(category);
            return RedirectToAction("Index");
        }
    }
}