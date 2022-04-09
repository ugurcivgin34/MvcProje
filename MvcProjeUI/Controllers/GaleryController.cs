using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUI.Controllers
{
    public class GaleryController : Controller
    {
        ImageFileManager ifm=new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var files = ifm.List();
            return View(files);
        }
    }
}