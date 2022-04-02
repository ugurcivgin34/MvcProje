using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void ContactAdd(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void ContentUpdate(Contact contact)
        {
            _contactDal.Update(contact);
        }

        public void Delete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public Contact GetById(int id)
        {
           return _contactDal.Get(c => c.ContactID == id);
        }

        public List<Contact> List()
        {
            return _contactDal.List();
        }
    }
}
