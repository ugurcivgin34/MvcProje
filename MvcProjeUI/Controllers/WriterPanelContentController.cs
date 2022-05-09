using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
        // GET: WriterPanelContent
        public ActionResult MyContent(string p)
        {
            Context c=new Context();
            p = (string)Session["WriterMail"];
            var writerInfo=c.Writers.Where(x=>x.WriterEmail == p).Select(y=>y.WriterID).FirstOrDefault();
            var contentValues = contentManager.GetListByWriter(writerInfo);
            return View(contentValues);
        }
    }
}