using entityLayer.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.validation
{
   public class aboutValidation : AbstractValidator<about>
    {
        public aboutValidation()
        {
            RuleFor(x => x.aboutValue).NotEmpty().WithMessage("About İçerik Alanı Boş Geçilemez !");
        }
    }
}
