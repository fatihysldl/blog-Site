using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.Abstract
{
    public interface IHeaderService
    {
        List<header> listing();
        header getId(int Id);
        void addHeader(header p);
        void updateHeader(header p);
        void deleteHeader(header p);
    }
}
