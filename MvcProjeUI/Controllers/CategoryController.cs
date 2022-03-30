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
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult GetCategoryList()
        {
            var categoryValues = cm.List();

            return View(categoryValues);
        }

        
        [HttpGet]//Sayfa ilk yüklendiğinde alttaki metod çalışacak
        public ActionResult AddCategory()
        {
            return View(); //bu sayfayı gerir döndürür
        }

        //Ben sayfamda bir butona tıkladığımda sayfada birşey post edildiği zaman aşağıdaki metod çalışacak
        [HttpPost]//Butona tıklandığında alttaki metod çalışacak
        public ActionResult AddCategory(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(category);
            if (results.IsValid) //Geçerli ise
            {
                cm.CategoryAddBL(category);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in results.Errors) 
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }

    }
}