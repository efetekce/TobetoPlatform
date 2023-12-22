using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class AccountCourseLessonBusinessRules : BaseBusinessRules
    {
        private readonly IAccountDal _accountDal;
        private readonly ILessonDal _lessonDal;
        private readonly ILessonStatusDal _lessonStatusDal;
        
        public AccountCourseLessonBusinessRules(IAccountDal accountDal, ILessonDal lessonDal, ILessonStatusDal lessonStatusDal)
        {
            _accountDal = accountDal;
            _lessonDal = lessonDal;
            _lessonStatusDal = lessonStatusDal;
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

        public async Task MustBeLessonDefined(int lessonId)
        {
            var result = await _lessonDal.GetListAsync(
                predicate: p => p.Id == lessonId
                );
            if (result.Count == 0)
            {
                throw new BusinessException(BusinessMessages.RequiredLesson);
            }
        }

        public async Task MustBeLessonStatusDefined(int lessonStatusId)
        {
            var result = await _lessonStatusDal.GetListAsync(
                predicate: p => p.Id == lessonStatusId
                );
            if (result.Count == 0)
            {
                throw new BusinessException(BusinessMessages.RequiredLessonStatus);
            }
        }
    }
}
