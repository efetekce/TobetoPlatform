using Business.Dtos.Request;
using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class EducationProgramValidator : AbstractValidator<CreateEducationProgramRequest>
    {
        public EducationProgramValidator()
        {
            RuleFor(e => e.Name)
                .NotEmpty().WithMessage("Doldurulması zorunlu alan!");
            RuleFor(e => e.Name).MinimumLength(2).WithMessage("En az 2 karakter girmelisiniz!");
            RuleFor(e => e.Name).MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz!");
        }
    }
}
