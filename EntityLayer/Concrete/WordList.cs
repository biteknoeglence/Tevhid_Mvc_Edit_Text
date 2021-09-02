using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WordList
    {
        [Key]
        public int WordID { get; set; }
        [StringLength(50)]
        public string Word { get; set; }
        [StringLength(50)]
        public string WordAdd { get; set; }
        [StringLength(50)]
        public string WordDelete { get; set; }
        [StringLength(50)]
        public string WordEdit { get; set; }

    }
}
