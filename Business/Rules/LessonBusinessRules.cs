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
    public class LessonBusinessRules : BaseBusinessRules
    {
        private readonly ICourseContentDal _courseContentDal;
        private readonly ICourseDal _courseDal;

        public LessonBusinessRules(ICourseContentDal courseContentDal, ICourseDal courseDal)
        {
            _courseContentDal = courseContentDal;
            _courseDal = courseDal;
        }

        public async Task LessonNameCantBeNull(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new BusinessException(BusinessMessages.NotNullableLessonName);
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

        public async Task MustBeContentDefined(int contentId)
        {
            var result = await _courseContentDal.GetListAsync(
                predicate: p => p.Id == contentId
                );
            if (result.Count == 0)
            {
                throw new BusinessException(BusinessMessages.RequiredContent);
            }
        }
    }
}
