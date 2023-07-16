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
    public class authorManager : IAuthorService
    {
        IAuthorDal _authorDal;

        public authorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public void addAuthor(author p)
        {
            _authorDal.insert(p);
        }

        public void deleteAuthor(author p)
        {
            _authorDal.delete(p);
        }

        public author getId(int Id)
        {
            return _authorDal.get(x => x.authorId == Id);
        }

        public List<author> listing()
        {
            return _authorDal.list();
        }

        public void updateAuthor(author p)
        {
            _authorDal.update(p);
        }
    }
}
