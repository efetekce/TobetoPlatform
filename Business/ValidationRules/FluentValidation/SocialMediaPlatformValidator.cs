using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class SocialMediaPlatformValidator : AbstractValidator<SocialMediaPlatform>
    {
        public SocialMediaPlatformValidator()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage("Doldurulması zorunlu alan!");
        }
    }
}
