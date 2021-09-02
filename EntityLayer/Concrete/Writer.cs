﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        
        [StringLength(50)]
        public string WriterName { get; set; }

        [StringLength(100)]
        public string WriterImage { get; set; }
        
        [StringLength(100)]
        public string WriterAbout { get; set; }

        [StringLength(100)]
        public string WriterProfession { get; set; }

        [StringLength(50)]
        public string WriterMail { get; set; }

        [StringLength(50)]
        public string WriterPassword { get; set; }

        [StringLength(1000)]
        public string WriterProduct { get; set; }


        public ICollection<Heading> Headings { get; set; }

        public ICollection<Content> Contents { get; set; }


    }
}