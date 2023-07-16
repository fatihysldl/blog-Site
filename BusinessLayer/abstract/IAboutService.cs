using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.Abstract
{
    public interface IAboutService
    {
        List<about> listing();
        about getId(int Id);

        void deleteAbout(about p);
        void updateAbout(about p);
    }
}
