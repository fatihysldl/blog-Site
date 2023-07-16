using DataAccessLayer.concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.abstracts.repository
{
    public class genericRepository<T> : IRepository<T> where T : class
    {
        context a = new context();
        DbSet<T> _object;

        public genericRepository()
        {
            _object = a.Set<T>();
        }

        public void delete(T p)
        {
            var deletedEntity = a.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            //_object.Remove(p);
            a.SaveChanges();
        }

        public T get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void insert(T p)
        {
            var addedEntity = a.Entry(p);
            addedEntity.State = EntityState.Added;
            a.SaveChanges();
        }

        public List<T> list()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void update(T p)
        {
            var updatedEntity = a.Entry(p);
            updatedEntity.State = EntityState.Modified;
            a.SaveChanges();
        }
    }
}
