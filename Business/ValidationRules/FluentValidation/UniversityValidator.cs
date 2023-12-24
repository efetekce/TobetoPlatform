using Core.Entities;
using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UniversityValidator:AbstractValidator<University>
    {
        public UniversityValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage("Doldurulması zorunlu alan!");
            RuleFor(u=>u.Name).MinimumLength(2).WithMessage("En az 2 karakter girmelisiniz!");
            RuleFor(u=>u.Name).MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz!");
        }
    }
}
