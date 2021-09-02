using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface ISubjectService
    {
        List<Subject> GetList();
        void SubjectAdd(Subject subject);
        void SubjectDelete(Subject subject);
        void SubjectUpdate(Subject subject);
        Subject GetById(int id);
    }

}
