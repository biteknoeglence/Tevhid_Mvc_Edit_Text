using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class SubjectValidator:AbstractValidator<Subject>
    {
        public SubjectValidator()
        {
            RuleFor(x => x.SubjectName).NotEmpty().WithMessage("Konu adını boş geçemezsiniz");
            RuleFor(x => x.SubjectDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz");
            RuleFor(x => x.SubjectName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.SubjectName).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayın");
            
        }
    }
}
