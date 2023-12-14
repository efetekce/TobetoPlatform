using Core.Business.Rules;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class ExperienceBusinessRules:BaseBusinessRules
    {
        private readonly IExperienceDal _experienceDal;

        public ExperienceBusinessRules(IExperienceDal experienceDal)
        {
            _experienceDal= experienceDal;
        }

        public async Task RuleExp(int id)
        {

        }
    }
}
