using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> List();
        Contact GetById(int id);
        void Delete(Contact contact);
        void ContactAdd(Contact contact);
        void ContentUpdate(Contact contact);
    }
}
