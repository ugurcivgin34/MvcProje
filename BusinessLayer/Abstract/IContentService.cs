using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> List();
        List<Content> GetListByWriter();

        List<Content> ListByHeadingID(int id);
        Content GetById(int id);
        void Delete(Content content);
        void ContentAddBL(Content content);
        void ContentUpdate(Content content);
    }
}
