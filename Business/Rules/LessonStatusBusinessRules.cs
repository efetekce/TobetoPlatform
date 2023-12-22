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
    public class LessonStatusBusinessRules : BaseBusinessRules
    {
        private readonly ILessonStatusDal _lessonStatusDal;

        public LessonStatusBusinessRules(ILessonStatusDal lessonStatusDal)
        {
            _lessonStatusDal = lessonStatusDal;
        }

        public async Task StatusNameCantBeNull(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new BusinessException(BusinessMessages.NotNullableLessonStatusName);
            }
        }
    }
}
