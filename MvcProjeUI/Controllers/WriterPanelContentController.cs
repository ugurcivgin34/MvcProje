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
    public class WriterPanelContentController : Controller
    {
        ContentManager contentManager = new ContentManager(new EfContentDal());
        Context c = new Context();

        // GET: WriterPanelContent
        public ActionResult MyContent(string p)
        {
            p = (string)Session["WriterMail"];
            var writerInfo=c.Writers.Where(x=>x.WriterEmail == p).Select(y=>y.WriterID).FirstOrDefault();
            var contentValues = contentManager.GetListByWriter(writerInfo);
            return View(contentValues);
        }

        [HttpGet]
        public ActionResult AddContent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContent(Content p)
        {
            string mail = (string)Session["WriterMail"];
            var writerInfo = c.Writers.Where(x => x.WriterEmail == mail).Select(y => y.WriterID).FirstOrDefault();
            p.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterID = writerInfo;
            p.ContentStatus = true;
            contentManager.ContentAddBL(p);
            return RedirectToAction("MyContent");
        }
    }
}