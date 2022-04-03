using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(m => m.ReceiverMail).NotEmpty().WithMessage("Alıcı  Adresini Boş geçemezsiniz");
            RuleFor(m => m.Subject).NotEmpty().WithMessage("Konuyu Boş geçemezsiniz");
            RuleFor(m => m.MessageContent).NotEmpty().WithMessage("Mesajı Boş geçemezsiniz");
            RuleFor(m => m.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(m => m.Subject).MaximumLength(100).WithMessage("Lütfen 100 karakterden fazla değer girişi yapmayınız");
        }
    }
}
