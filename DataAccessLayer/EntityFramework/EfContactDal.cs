using DataAccessLayer.abstracts;
using DataAccessLayer.abstracts.repository;
using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactDal : genericRepository<contact>, IContactDal
    {
    }
}
