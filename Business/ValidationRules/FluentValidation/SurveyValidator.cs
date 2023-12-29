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
    public class SurveyValidator:AbstractValidator<CreateSurveyRequest>
    {
        public SurveyValidator()
        {
            //public string Title { get; set; }
            //public string Content { get; set; }
            //public string Link { get; set; }
            //public DateTime PublishedDate { get; set; }

            RuleFor(s => s.Title).NotEmpty().WithMessage("Doldurulması zorunlu alan!");
            RuleFor(s => s.Content).NotEmpty().WithMessage("Doldurulması zorunlu alan!");
            RuleFor(s => s.Link).NotEmpty().WithMessage("Doldurulması zorunlu alan!");
        }
    }
}
