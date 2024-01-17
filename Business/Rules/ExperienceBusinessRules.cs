using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Entities;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class ExperienceBusinessRules : BaseBusinessRules
    {
        private readonly IAccountExperienceDal _experienceDal;

        public ExperienceBusinessRules(IAccountExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public async Task ExperienceRule(string position, string companyName, int cityId)
        {
            if (string.IsNullOrEmpty(position) || string.IsNullOrEmpty(companyName) || cityId==0)
            {
                throw new BusinessException(BusinessMessages.ExperienceCannotBeEmpty);
            }

            var result = await _experienceDal.GetListAsync(e => e.Position == position && e.CompanyName == companyName);

            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.ExperienceRuleError);
            }
        }
    }
}
