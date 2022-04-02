using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(c => c.UserMail).NotEmpty().WithMessage("Mail Adresini Boş Geçemezsiniz");
            RuleFor(c => c.Subject).NotEmpty().WithMessage("Konu Adını Boş Geçemezsiniz");
            RuleFor(c => c.UserName).NotEmpty().WithMessage("Kullanıcı Adını Boş Geçemezsiniz");
            RuleFor(c => c.Subject).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girmelisiniz");
            RuleFor(c => c.UserName).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girmelisiniz");
            RuleFor(c => c.Subject).MaximumLength(50).WithMessage("Lütfen 0 karakterden fazla değer girişi yapmayınız");
        
        }
    }
}
