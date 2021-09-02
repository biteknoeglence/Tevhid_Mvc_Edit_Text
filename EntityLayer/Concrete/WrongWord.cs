using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WrongWord
    {
        [Key]
        public int WrongID { get; set; }
        [StringLength(50)]
        public string WrongName { get; set; }
        [StringLength(50)]
        public string Advices { get; set; }
        [StringLength(50)]
        public string Chosen { get; set; }
        [StringLength(50)]
        public string Edit { get; set; }
    }
}
