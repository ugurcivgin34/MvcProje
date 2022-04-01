using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> List();
        About GetById(int id);
        void Delete(About about);
        void AboutAdd(About about);
        void AboutUpdate(About about);
    }
}
