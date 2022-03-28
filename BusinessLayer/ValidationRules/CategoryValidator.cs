using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c=>c.CategoryName).NotEmpty().WithMessage("Kategorini Adını Boş Geçemezsiniz");
            RuleFor(c=>c.CategoryDescription).NotEmpty().WithMessage("Açıklamayı Boş Geçemezsiniz");
            RuleFor(c => c.CategoryName).MinimumLength(3).WithMessage("En Az 3 Karakter Girmelisiniz");
            RuleFor(c => c.CategoryName).MaximumLength(20).WithMessage("En Fazla 20 Karakter Girmelisiniz");

        }
    }
}
