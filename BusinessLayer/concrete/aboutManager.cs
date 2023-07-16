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
    public class aboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public aboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void deleteAbout(about p)
        {
            _aboutDal.delete(p);
        }

        public about getId(int Id)
        {
            return _aboutDal.get(x => x.aboutId == Id);
        }

        public List<about> listing()
        {
            return _aboutDal.list();
        }

        public void updateAbout(about p)
        {
            _aboutDal.update(p);
        }
    }
}
