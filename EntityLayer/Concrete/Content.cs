using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {//İçerik
        [Key]
        public int ContentId { get; set; }
        public int HeadingId { get; set; }
        public int? WriterId { get; set; }

        [StringLength(1000)]
        public string ContentText { get; set; }
        public DateTime ContentDate { get; set; }

        public virtual Heading Heading { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
