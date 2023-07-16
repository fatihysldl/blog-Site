using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.abstracts
{
   public  interface IRepository <T>
    {
        List<T> list();
        void insert(T p);
        T get(Expression<Func<T, bool>> filter);
        void update(T p);
        void delete(T p);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
