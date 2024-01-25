using Business.Constants.Messages;
using Business.Dtos.Request;
using Core.CrossCuttingConcerns.Exceptions.Types;
using FluentValidation;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AccountValidator : AbstractValidator<CreateAccountRequest>
    {
        public AccountValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("Ad alanı boş olamaz!");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Soyad alanı boş olamaz!");

            RuleFor(c => c.PhoneNumber).NotEmpty().WithMessage("Telefon Numarası alanı boş olamaz!");
            RuleFor(c => c.PhoneNumber).Must(MustBeANumberField).WithMessage("Geçerli bir kayıt giriniz!");

            RuleFor(c => c.BirthDate).NotEmpty().WithMessage("Doğum Tarihi alanı boş olamaz!")
            .Must(BeAValidYear).WithMessage("Geçerli bir tarih olmalıdır.");
            
            RuleFor(c => c.NationalId).Must(MustBeANumberField).WithMessage("Geçerli bir kayıt giriniz!")
                .MaximumLength(11).WithMessage("En fazla 11 karakter girebilirsiniz!")
                .NotEmpty().WithMessage("Tc kimlik no alanı boş olamaz!");
            
            RuleFor(c => c.Email).NotEmpty().WithMessage("E-posta alanı boş olamaz!")
                .Must(MailFormat).WithMessage("Geçersiz e-posta formatı.");
        }

        private bool BeAValidYear(DateTime year)
        {
            //Girilen tarihin geçerli zaman aralığında olup olmadığını kontrol etme.
            int currentYear = DateTime.Now.Year;
            return currentYear - year.Year >= 18;
        }

        private bool MustBeANumberField(string value)
        {
            // Numara olup olmadığını kontrol et
            bool response = int.TryParse(value, out _) ? true : false;
            return response;
        }

        private bool MailFormat(string mail)
        {
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            bool result = Regex.IsMatch(mail, emailPattern);
            return result;
        }
    }
}
