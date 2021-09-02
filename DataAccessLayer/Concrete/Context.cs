using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    //burada belirlenen propertyler birer tablo ismi olarak SQLde karşılık bulacak
    public class Context : DbContext
    {
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<WordList> WordLists { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<WrongWord> WrongWords { get; set; }
    }
}
