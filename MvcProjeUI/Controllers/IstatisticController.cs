using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUI.Controllers
{
    public class IstatisticController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        // GET: Istatistic
        public ActionResult Index()
        {              
            ViewBag.Deger1 = cm.List().Count; //Kategori Sayısı
            ViewBag.Deger2 = hm.List().Where(h => h.CategoryID == 10).Count(); //Yazılım Kategorisindeki Başlık sayısı
            ViewBag.Deger3 = wm.GetList().Where(w => w.WriterName.Contains("a") || w.WriterName.Contains("A")).Count(); //içinde a harfi geçen yazar sayısı
            ViewBag.Deger4=  cm.List().Where(x => x.CategoryID == (hm.List().GroupBy(h => h.CategoryID)).Select(y => y.Key).FirstOrDefault()).Select(k => k.CategoryName).FirstOrDefault();//En fazla başlığa sahip kategori
            ViewBag.Deger5 = cm.List().Where(x => x.CategoryStatus == true).Count(); //True olan kategori sayısı
            return View();
        }
    }
}