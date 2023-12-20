using Core.Business.Rules;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class EducationBusinessRules:BaseBusinessRules
    {
        private readonly IEducationDal _educationDal;

        public EducationBusinessRules(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public async Task RuleEdu(int id)
        {

        }
    }
}
