using entityLayer.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.validation
{
    public class headerValidation : AbstractValidator<header>
    {
        public headerValidation()
        {
            RuleFor(i => i.headerName).NotEmpty().WithMessage("Anasayfa Ana Başlık Alanı Boş Geçilemez");
            RuleFor(i => i.headerDescription).NotEmpty().WithMessage("Anasayfa Ana Başlık Açıklama Alanı Boş Geçilemez");
        }
    }
}
