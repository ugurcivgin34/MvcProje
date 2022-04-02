using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUI.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        // GET: Contact
        public ActionResult Index()
        {
            var contactValues = cm.List();
            return View(contactValues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactValues = cm.GetById(id);
            return View(contactValues);
        }

        public PartialViewResult ContactPartial()
        {
            return PartialView();
        }

    }
}