using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> List();
        Category GetById(int id);
        void Delete(Category category);
        void CategoryAddBL(Category category);
        void CategoryUpdate(Category category);
    }
}
