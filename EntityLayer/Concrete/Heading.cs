using EntityLayer.Abstarct;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading: IEntity
    {
        [Key]
        public int HeadingID { get; set; }
        public int CategoryID { get; set; } // Bağlayacağımız sutunu ekledik
        public int WriterID { get; set; }

        public bool HeadingStatus { get; set; }


        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<Content> Contents { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
