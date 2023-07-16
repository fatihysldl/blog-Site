using businessLayer.Abstract;
using DataAccessLayer.abstracts;
using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.concrete
{
    public class categoryManager : ICategoryService
    {
        ICatetgoryDal _categoryDal;

        public categoryManager(ICatetgoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void addCategory(category p)
        {
            _categoryDal.insert(p);
        }

        public void deleteCategory(category p)
        {
            _categoryDal.delete(p);
        }

        public category getId(int Id)
        {
            return _categoryDal.get(x => x.categoryId == Id);
        }

        public List<category> listing()
        {
            return _categoryDal.list();
        }

        public void updateCategory(category p)
        {
            _categoryDal.update(p);
        }
    }
}
