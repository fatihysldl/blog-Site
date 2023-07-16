using entityLayer.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.validation
{
    public class authorValidation :AbstractValidator<author>
    {
        public authorValidation()
        {
            RuleFor(i => i.authorName).NotEmpty().WithMessage("Yazar Adı Boş Geçilemez!");
            RuleFor(i => i.authorSurname).NotEmpty().WithMessage("Yazar Soyadı Boş Geçilemez!");
            RuleFor(i => i.authorMail).NotEmpty().WithMessage("Yazar Maili Boş Geçilemez!");
        }
    }
}
