using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class SubjectRepository : ISubjectDal

    {
        //Bu yanlış interface, her sınıf için farklı interface gerek yok. Sadece IRepository yeterli
        Context c = new Context();
        DbSet<Subject> _object;

        public void Delete(Subject p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public Subject Get(Expression<Func<Subject, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Subject p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Subject> List()
        {
            return _object.ToList();
        }

        public List<Subject> List(Expression<Func<Subject, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Subject p)
        {
            c.SaveChanges();
        }
    }
}
