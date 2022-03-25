using BusinessLayer.Concrete;
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
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        ContactManager cm = new ContactManager();

        public ActionResult GetContactList()
        {
            var contactValues = cm.GetAll();

            return View(contactValues);
        }
        [HttpGet]//Sayfa ilk yüklendiğinde alttaki metod çalışacak
        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]//Butona tıklandığında alttaki metod çalışacak
        public ActionResult AddContact(Contact contact)
        {
            cm.ContactAddBL(contact);
            return RedirectToAction("GetContactList");
        }
    }
}