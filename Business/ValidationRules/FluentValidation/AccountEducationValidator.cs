using Business.Constants.Messages;
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
    public class AccountEducationValidator : AbstractValidator<CreateAccountEducationRequest>
    {
        public AccountEducationValidator()
        {
            RuleFor(a => a.StartYear).NotEmpty().WithMessage("Doldurulması zorunlu alan!")
                .Must(BeAValidYear).WithMessage("Geçerli bir başlangıç yılı olmalıdır.");

            RuleFor(a => a.GraduationYear).NotEmpty().WithMessage("Doldurulması zorunlu alan!")
                .Must(BeAValidYear).WithMessage("Geçerli bir mezuniyet yılı olmalıdır.")
                .GreaterThanOrEqualTo(a => a.StartYear).WithMessage("Mezuniyet yılı, başlangıç yılından küçük olamaz.");

            RuleFor(a => a.IsGraduated).NotEmpty().WithMessage(BusinessMessages.AccountApplicationCannotBeEmpty);
        }

        private bool BeAValidYear(DateTime year)
        {
            //Girilen tarihin geçerli zaman aralığında olup olmadığını kontrol etme.
            int currentYear = DateTime.Now.Year;
            return year.Year >= 1973 && year.Year <= currentYear;
        }
    }
}
