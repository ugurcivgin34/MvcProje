using BusinessLayer.Concrete;
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

        CategoryManager cm = new CategoryManager();
        public ActionResult GetCategoryList()
        {
            var categoryValues = cm.GetAll();

            return View(categoryValues);
        }
    }
}