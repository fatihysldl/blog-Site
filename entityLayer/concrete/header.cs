using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class header
    {
        [Key]
        public int headerId { get; set; }
        [StringLength(30)]
        public string headerName { get; set; }
        [StringLength(40)]
        public string headerDescription { get; set; }
    }
}
