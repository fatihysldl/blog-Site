using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class contact
    {
        [Key]
        public int contactId { get; set; }

        [StringLength(30)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string UserMail { get; set; }

        [StringLength(70)]
        public string contactTopic { get; set; }
        public string contactMessage { get; set; }
    }
}
