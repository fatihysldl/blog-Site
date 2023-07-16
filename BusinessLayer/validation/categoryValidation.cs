using entityLayer.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.validation
{
    public class categoryValidation :AbstractValidator<category>
    {
        public categoryValidation()
        {
            RuleFor(i => i.categoryName).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
        }
    }
}
