using entityLayer.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.validation
{
    public class postValidation : AbstractValidator<post>
    {
        public postValidation()
        {
            RuleFor(x => x.postHeader).NotEmpty().WithMessage("post başlığı boş geçilemez!");
            RuleFor(x => x.postDescription).NotEmpty().WithMessage("post açıklama boş geçilemez!");
            RuleFor(x => x.postDate).NotEmpty().WithMessage("post tarihi boş geçilemez!");
            RuleFor(x => x.contentValue).NotEmpty().WithMessage("post içeriği boş geçilemez!");
            RuleFor(x => x.categoryId).NotEmpty().WithMessage("post category alanı boş geçilemez!");
            RuleFor(x => x.authorId).NotEmpty().WithMessage("post yazar alanı boş geçilemez!");

        }
    }
}
