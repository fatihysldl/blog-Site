using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class category
    {
        [Key]
        public int categoryId { get; set; }

        [StringLength(50)]
        public string categoryName { get; set; }
    }
}
