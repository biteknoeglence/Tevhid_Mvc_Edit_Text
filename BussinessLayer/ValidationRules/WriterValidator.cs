using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail boş geçemezsiniz");
            RuleFor(x => x.WriterPassword).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.WriterProduct).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.WriterAbout).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayın");
            RuleFor(x => x.WriterImage).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayın");

        }
    }
}
