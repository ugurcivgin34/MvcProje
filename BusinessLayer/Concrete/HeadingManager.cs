using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        private IHeadingDal _headingdal;

        public HeadingManager(IHeadingDal headingdal)
        {
            _headingdal = headingdal;
        }

        public void HeadingAddBL(Heading heading)
        {
            _headingdal.Insert(heading);
        }

        public void HeadingUpdate(Heading heading)
        {
            _headingdal.Update(heading);
        }

        public void Delete(Heading heading)
        {
            _headingdal.Delete(heading);
        }

        public Heading GetById(int id)
        {
            return _headingdal.Get(h => h.HeadingID == id);
        }

        public List<Heading> List()
        {
            return _headingdal.List();
        }
    }
}
