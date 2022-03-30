using EntityLayer.Abstarct;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About : IEntity
    {
        [Key]
        public int AboutID { get; set; }

        [StringLength(100)] //BUrda tanımlama yapmazsan veritabanı kısmında nvarcharmax olarak tanımlanır
        public string AboutDetails1 { get; set; }
        public string AboutDetails2 { get; set; }

        [StringLength(100)]
        public string AboutImage1 { get; set; }
        public string AboutImage2 { get; set; }
    }
}
