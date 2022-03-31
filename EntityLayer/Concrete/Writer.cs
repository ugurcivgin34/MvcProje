using EntityLayer.Abstarct;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer: IEntity
    {//Yazar
        [Key]
        public int WriterID { get; set; }

        [StringLength(20)]
        public string WriterName { get; set; }

        [StringLength(20)]
        public string WriterSurname { get; set; }

        [StringLength(50)]
        public string WriterEmail { get; set; }

        [StringLength(200)]
        public string WriterPassword { get; set; }

        [StringLength(50)]
        public string WriterTitle { get; set; }

        [StringLength(200)]
        public string WriterAbout { get; set; }

        [StringLength(250)]
        public string WriterImage { get; set; }

        public ICollection<Content> Contents { get; set; }
        public ICollection<Heading> Headings { get; set; }


    }
}
