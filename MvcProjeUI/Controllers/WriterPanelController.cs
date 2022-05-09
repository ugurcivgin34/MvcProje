using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUI.Controllers
{
    public class WriterPanelController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        Context c = new Context();


        // GET: WriterPanel
        public ActionResult WriterProfile()
        {
            return View();
        }

        public ActionResult MyHeading( string p)
        {
            p = (string)Session["WriterMail"];
            var writerIdInfo=c.Writers.Where(x=>x.WriterEmail==p).Select(y=>y.WriterID).FirstOrDefault();
            var values = hm.ListByWriter(writerIdInfo);
            return View(values); 
        }
        [HttpGet]
        public ActionResult NewHeading()
        {
            List<SelectListItem> valuecategory = (from x in cm.List()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }
                                                ).ToList();
            ViewBag.vlc = valuecategory;

            return View();
        }
        [HttpPost]
        public ActionResult NewHeading(Heading heading)
        {
            heading.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            heading.WriterID = 1;
            heading.HeadingStatus = true;
            hm.HeadingAddBL(heading);
            return RedirectToAction("MyHeading");
        }

        [HttpGet]
        public ActionResult EditHeading(int id)
        {

            List<SelectListItem> valuecategory = (from x in cm.List()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }
                                               ).ToList();
            ViewBag.vlc = valuecategory;
            var headingValue = hm.GetById(id);
            return View(headingValue);
        }

        [HttpPost]
        public ActionResult EditHeading(Heading heading)
        {
            hm.HeadingUpdate(heading);
            return RedirectToAction("MyHeading");
        }

        public ActionResult DeleteHeading(int id)
        {
            var headingValue = hm.GetById(id);
            headingValue.HeadingStatus = false;
            hm.HeadingDelete(headingValue);
            return RedirectToAction("MyHeading");
        }


    }
}

//< customErrors mode = "On" >
 
//       < error statusCode = "404" redirect = "/ErrorPage/Page404/" />
    
//        </ customErrors >