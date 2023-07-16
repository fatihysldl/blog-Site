using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.concrete
{
    public class context : DbContext
    {
        public DbSet<about> abouts { get; set; }
        public DbSet<author> authors { get; set; }
        public DbSet<category> categories { get; set; }
        public DbSet<contact> contacts { get; set; }
        public DbSet<header> headers { get; set; }
        public DbSet<post> posts { get; set; }
    }
}
