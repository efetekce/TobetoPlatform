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
    public class ExperienceValidator : AbstractValidator<CreateExperienceRequest>
    {
        public ExperienceValidator()
        {
            RuleFor(e => e.CompanyName).NotEmpty().WithMessage("Doldurulması zorunlu alan!");
            RuleFor(e => e.CompanyName).MinimumLength(5).WithMessage("En az 5 karakter girmelisiniz!");
            RuleFor(e => e.CompanyName).MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz!");
            RuleFor(e => e.Position).NotEmpty().WithMessage("Doldurulması zorunlu alan!");
            RuleFor(e => e.Position).MinimumLength(5).WithMessage("En az 5 karakter girmelisiniz!");
            RuleFor(e => e.Position).MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz!");
            RuleFor(e => e.Field).NotEmpty().WithMessage("Doldurulması zorunlu alan!");
            RuleFor(e => e.Field).MinimumLength(5).WithMessage("En az 5 karakter girmelisiniz!");
            RuleFor(e => e.Field).MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz!");
            RuleFor(e => e.JobDescription).MaximumLength(300).WithMessage("En fazla 300 karakter girebilirsiniz!");
            RuleFor(e => e.StartDate).NotEmpty().WithMessage("Doldurulması zorunlu alan!");
            RuleFor(e => e.EndDate).NotEmpty().WithMessage("Doldurulması zorunlu alan!");
            RuleFor(e => e.EndDate).GreaterThanOrEqualTo(e => e.StartDate).WithMessage("Bitiş tarihi, başlangıç tarihinden büyük veya eşit olmalıdır!");
            RuleFor(e => e.StartDate)
                   .Must(BeValidDate).WithMessage("Tarih, 'dd.MM.yyyy' formatında olmalıdır.");
            RuleFor(e => e.EndDate)
                .Must(BeValidDate).WithMessage("Tarih, 'dd.MM.yyyy' formatında olmalıdır.");
        }

        private bool BeValidDate(DateTime date)
        {
            return true; 
        }
    }
}
