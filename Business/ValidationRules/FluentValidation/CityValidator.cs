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
    public class CityValidator:AbstractValidator<City>
    {
        public CityValidator()
        {
            //RuleFor(c => c.Name).NotEmpty().WithMessage("Doldurulması zorunlu alan!");
            RuleFor(c => c.Name).NotEmpty().WithMessage("Doldurulması zorunlu alan!");
        }
    }
}


