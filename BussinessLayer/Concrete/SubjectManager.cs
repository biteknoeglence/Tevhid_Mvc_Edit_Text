using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class SubjectManager : ISubjectService
    {
        ISubjectDal _subjectDal;

        public SubjectManager(ISubjectDal subjectDal)
        {
            _subjectDal = subjectDal;
        }

        public Subject GetById(int id)
        {
            return _subjectDal.Get(x => x.SubjectID == id);
        }

        public List<Subject> GetList()
        {
            return _subjectDal.List();
        }

        public void SubjectAdd(Subject subject)
        {
            _subjectDal.Insert(subject);

        }

        public void SubjectDelete(Subject subject)
        {
            _subjectDal.Delete(subject);
        }

        public void SubjectUpdate(Subject subject)
        {
            _subjectDal.Update(subject);
        }



        //GenericRepository<Subject> repo = new GenericRepository<Subject>();

        //public List<Subject> GetAllBL()
        //{
        //    return repo.List();
        //}

        //public void SubjectAddBL(Subject p)
        //{
        //    if (p.SubjectName == "" || p.SubjectName.Length <= 3 || p.SubjectDescription == "" || p.SubjectName.Length >= 51)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }

        //}

    }
}
