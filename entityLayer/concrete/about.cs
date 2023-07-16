using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class about
    {
        [Key]
        public int aboutId { get; set; }
        public string aboutValue { get; set; }

        [StringLength(150)]
        public string aboutImage { get; set; }
    }
}
