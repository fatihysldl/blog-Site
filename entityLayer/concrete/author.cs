using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class author
    {
        [Key]
        public int authorId { get; set; }

        [StringLength(50)]
        public string authorName { get; set; }

        [StringLength(50)]
        public string authorSurname { get; set; }

        [StringLength(80)]
        public string authorMail { get; set; }

        //Relationships
        public ICollection<post> posts { get; set; }
    }
}
