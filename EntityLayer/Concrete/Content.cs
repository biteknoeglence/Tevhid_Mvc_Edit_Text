using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }

        [StringLength(50)]
        public string Chosen { get; set; }
        [StringLength(50)]
        public string WrongWord { get; set; }
        [StringLength(50)]
        public string ContEdited { get; set; }
        [StringLength(50)]
        public string ContOriginal { get; set; }
        public DateTime ContentDate { get; set; }

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }



    }
}
