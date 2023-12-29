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
    public class SurveyValidator:AbstractValidator<CreateSurveyRequest>
    {
        public SurveyValidator()
        {
            RuleFor(s => s.Title).NotEmpty().WithMessage(BusinessMessages.RequiredField);
            RuleFor(s => s.Content).NotEmpty().WithMessage(BusinessMessages.RequiredField);
            RuleFor(s => s.Link).NotEmpty().WithMessage(BusinessMessages.RequiredField);
        }
    }
}
