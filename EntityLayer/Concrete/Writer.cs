﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {//Yazar
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterEmail { get; set; }
        public string Password { get; set; }

        public ICollection<Content> Contents { get; set; }
        public ICollection<Heading> Headings { get; set; }


    }
}
