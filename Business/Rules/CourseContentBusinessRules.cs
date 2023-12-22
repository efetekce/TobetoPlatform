using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class CourseContentBusinessRules : BaseBusinessRules
    {
        private readonly ICourseContentDal _courseContentDal;
        private readonly ICourseDal _courseDal;
        private readonly ICourseContentTypeDal _courseContentTypeDal;

        public CourseContentBusinessRules(ICourseContentDal courseContentDal, ICourseDal courseDal, ICourseContentTypeDal courseContentTypeDal)
        {
            _courseContentDal = courseContentDal;
            _courseDal = courseDal;
            _courseContentTypeDal = courseContentTypeDal;
        }

        public async Task ContentNameCantBeNull(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new BusinessException(BusinessMessages.NotNullableContentName);
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

        public async Task MustBeContentTypeDefined(int contentTypeId)
        {
            var result = await _courseContentTypeDal.GetListAsync(
                predicate: p => p.Id == contentTypeId
                );
            if (result.Count == 0)
            {
                throw new BusinessException(BusinessMessages.RequiredContentType);
            }
        }
    }
}
