using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUI.Controllers
{
    public class WriterController : Controller
    {
        // GET: Writer
        public ActionResult Index()
        {
            return View();
        }

        WriterManager wm = new WriterManager();
        public ActionResult GetWriterList()
        {
            var writerValues = wm.GetAll();

            return View(writerValues);
        }

        [HttpGet]//Sayfa ilk yüklendiğinde alttaki metod çalışacak
        public ActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]//Butona tıklandığında alttaki metod çalışacak
        public ActionResult AddWriter(Writer writer)
        {
            wm.WriterAddBL(writer);
            return RedirectToAction("GetWriterList");
        }
    }
}