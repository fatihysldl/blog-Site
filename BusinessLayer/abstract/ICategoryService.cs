using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.Abstract
{
    public interface ICategoryService
    {
        List<category> listing();
        void addCategory(category p);
        category getId(int Id);
        void updateCategory(category p);
        void deleteCategory(category p);
    }
}
