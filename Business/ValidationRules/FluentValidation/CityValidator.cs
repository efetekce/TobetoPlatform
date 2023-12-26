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
    public class CityValidator:AbstractValidator<CreateCityRequest>
    {
        public CityValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Doldurulması zorunlu alan!");
            RuleFor(c => c.Name).MinimumLength(4);
        }
    }
}


