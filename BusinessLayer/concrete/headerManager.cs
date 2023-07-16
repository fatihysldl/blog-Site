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
    public class headerManager : IHeaderService
    {
        IHeaderDal _headerDal;

        public headerManager(IHeaderDal headerDal)
        {
            _headerDal = headerDal;
        }

        public void addHeader(header p)
        {
            _headerDal.insert(p);
        }

        public void deleteHeader(header p)
        {
            _headerDal.delete(p);
        }

        public header getId(int Id)
        {
            return _headerDal.get(x => x.headerId == Id);
        }

        public List<header> listing()
        {
            return _headerDal.list();
        }

        public void updateHeader(header p)
        {
            _headerDal.update(p);
        }
    }
}
