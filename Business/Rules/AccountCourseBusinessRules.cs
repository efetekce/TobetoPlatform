using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class AccountCourseBusinessRules : BaseBusinessRules
    {
        private readonly IAccountCourseDal _accountCourseDal;
        private readonly IAccountDal _accountDal;
        private readonly ICourseDal _courseDal;
        public AccountCourseBusinessRules(IAccountCourseDal accountCourseDal, IAccountDal accountDal, ICourseDal courseDal)
        {
            _accountCourseDal = accountCourseDal;
            _accountDal = accountDal;
            _courseDal = courseDal;
        }

        public async Task MustBeAccountDefined(int accountId)
        {
            var result = await _accountDal.GetListAsync(
                predicate: p => p.Id == accountId
                );
            if (result.Count == 0)
            {
                throw new BusinessException(BusinessMessages.RequiredAccountForCourse);
            }
        }

        public async Task MustBeCourseDefined(int courseId)
        {
            var result = await _courseDal.GetListAsync(
                predicate: p => p.Id == courseId
                );
            if (result.Count == 0)
            {
                throw new BusinessException(BusinessMessages.RequiredCourse);
            }
        }

        public async Task InvalidRangeOfPercentage(int percentageOfCompletion)
        {
            
        }

        public async Task InvalidRangeOfPoint(int point)
        {

        }
    }
}
