using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class post
    {
        [Key]
        public int postId { get; set; }

        [StringLength(80)]
        public string postHeader { get; set; }

        [StringLength(100)]
        public string postDescription { get; set; }
        public DateTime postDate { get; set; }
        public bool status { get; set; }

        public int contentId { get; set; }

        public string contentValue { get; set; }

        // Relationships


        public int authorId { get; set; }
        public virtual author Author { get; set; }

        public int categoryId { get; set; }
        public virtual category Category { get; set; }

        
    }
}
