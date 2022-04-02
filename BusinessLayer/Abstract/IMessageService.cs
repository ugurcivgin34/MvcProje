using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> List();
        Message GetById(int id);
        void Delete(Message  message);
        void MessageAdd(Message message);
        void MessageUpdate(Message message);
    }
}
