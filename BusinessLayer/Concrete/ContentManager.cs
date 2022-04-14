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
    public class ContentManager : IContentService
    {
        private IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void ContentAddBL(Content content)
        {
            _contentDal.Insert(content);
        }

        public void ContentUpdate(Content content)
        {
            _contentDal.Update(content);
        }

        public void Delete(Content content)
        {
            _contentDal.Delete(content);
        }

        public Content GetById(int id)
        {
            return _contentDal.Get(c => c.ContentID == id);
        }

        public List<Content> GetListByWriter()
        {
            return _contentDal.List(x => x.WriterID == 3);
        }

        public List<Content> List()
        {
            return _contentDal.List();
        }

        public List<Content> ListByHeadingID(int id)
        {
            return _contentDal.List(c => c.HeadingID == id);
        }
    }
}
