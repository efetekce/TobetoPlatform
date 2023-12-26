﻿using Business.Constants.Messages;
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
    public class CountryValidator : AbstractValidator<CreateCountryRequest>
    {
        public CountryValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Ülke alanı boş olamaz!");
            RuleFor(c => c.Name).MinimumLength(2).WithMessage("En az 2 karakter girebilirsiniz!");
            RuleFor(c => c.Name).MaximumLength(30).WithMessage("En fazla 30 karakter girebilirsiniz!");
        }
    }
}
