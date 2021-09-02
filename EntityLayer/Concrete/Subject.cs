using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Subject
    {
        [Key]
        public int SubjectID { get; set; }
        [StringLength(50)]
        public string SubjectName { get; set; }
        [StringLength(500)]
        public string SubjectDescription { get; set; }
        public bool SubjectStatus { get; set; } //görünmesini istemediğimiz konuları false yaparız

        //ilişkili olacak sınıf
        public ICollection<Heading> Headings { get; set; }
    }
}
