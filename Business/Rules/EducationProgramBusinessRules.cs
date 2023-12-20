using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using DataAccess.Concretes;

namespace Business.Rules
{
    public class EducationProgramBusinessRules : BaseBusinessRules
    {
        IEducationProgramDal _educationProgramDal;
        public EducationProgramBusinessRules(IEducationProgramDal educationProgramDal)
        {
            _educationProgramDal = educationProgramDal;
        }

        public async Task MinimumEducationProgramName(string name)
        {
            if (name.Length < 5)
            {
                throw new BusinessException("");
            }
        }
    }
}

