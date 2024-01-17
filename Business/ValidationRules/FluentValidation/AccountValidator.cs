using Business.Constants.Messages;
using Business.Dtos.Request;
using FluentValidation;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AccountValidator : AbstractValidator<CreateAccountRequest>
    {
        public AccountValidator()
        {
            //Bu alanları dbde isrequired yaptık yine de gerekli mi ?
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("Ad alanı boş olamaz!");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Soyad alanı boş olamaz!");
            RuleFor(c => c.PhoneNumber).NotEmpty().WithMessage("Telefon Numarası alanı boş olamaz!");
            RuleFor(c => c.BirthDate).NotEmpty().WithMessage("Doğum Tarihi alanı boş olamaz!")
            .Must(BeAValidYear).WithMessage("Geçerli bir tarih olmalıdır.");
            RuleFor(c => c.NationalId).MaximumLength(11).WithMessage("En fazla 30 karakter girebilirsiniz!").NotEmpty().WithMessage("Tc kimlik no alanı boş olamaz!");
            RuleFor(c => c.Email).NotEmpty().WithMessage("E-posta alanı boş olamaz!");
        }

        private bool BeAValidYear(DateTime year)
        {
            //Girilen tarihin geçerli zaman aralığında olup olmadığını kontrol etme.
            int currentYear = DateTime.Now.Year;
            return currentYear - year.Year >= 18;
        }

        private bool MustBeANumberField(string nationalId)
        {
            // Numara olup olmadığını kontrol et
            bool response = int.TryParse(nationalId, out _) ? true : false;
            return response;
        }
    }
}
