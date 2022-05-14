using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUI.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult Headings()
        {
            var headingList = hm.List();
            return View(headingList);
        }
        public PartialViewResult Index()
        {
            var contentList = cm.List();
            return PartialView(contentList);
        }
    }
}