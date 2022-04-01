using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> List();
        Heading GetById(int id);
        void Delete(Heading heading);
        void HeadingAddBL(Heading heading);
        void HeadingUpdate(Heading heading);
        void HeadingDelete(Heading heading);
    }
}
