using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjeUI.Controllers
{
    public class LoginController : Controller
    {
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var adminUserInfo = adminManager.GetById(p);
            if (adminUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminUserInfo.AdminUserName, false);//Kalıcı cooki oluşmasın false yaptık
                Session["AdminUserName"] = adminUserInfo.AdminUserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        [HttpGet]
        public ActionResult WriterLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WriterLogin(Writer writer)
        {
            Context c = new Context();
            var writerUserInfo = c.Writers.FirstOrDefault(x => x.WriterEmail == writer.WriterEmail && x.WriterPassword == writer.WriterPassword);

            if (writerUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(writerUserInfo.WriterEmail, false);//Kalıcı cooki oluşmasın false yaptık
                Session["WriterMail"] = writerUserInfo.WriterEmail;
                return RedirectToAction("MyContent", "WriterPanelContent");
            }
            else
            {
                return RedirectToAction("WriterLogin");
            }
        }
    }
}