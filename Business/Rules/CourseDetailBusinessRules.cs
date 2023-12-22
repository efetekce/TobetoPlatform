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
    public class CourseDetailBusinessRules : BaseBusinessRules
    {
        private readonly ICourseDetailDal _courseDetailDal;
        private readonly ICourseDal _courseDal;
        private readonly ICourseContentDal _courseContentDal;
        private readonly ICourseCategoryDal _courseCategoryDal;
        private readonly IOrganizationDal _organizationDal;

        public CourseDetailBusinessRules(ICourseDetailDal courseDetailDal, ICourseDal courseDal, ICourseContentDal courseContentDal, ICourseCategoryDal courseCategoryDal, IOrganizationDal organizationDal)
        {
            _courseDetailDal = courseDetailDal;
            _courseDal = courseDal;
            _courseContentDal = courseContentDal;
            _courseCategoryDal = courseCategoryDal;
            _organizationDal = organizationDal;
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

        public async Task MustBeContentDefined(int content)
        {
            var result = await _courseContentDal.GetListAsync(
                predicate: p => p.Id == content
                );
            if (result.Count == 0)
            {
                throw new BusinessException(BusinessMessages.RequiredContent);
            }
        }

        public async Task MustBeCategoryDefined(int categoryId)
        {
            var result = await _courseCategoryDal.GetListAsync(
                predicate: p => p.Id == categoryId
                );
            if (result.Count == 0)
            {
                throw new BusinessException(BusinessMessages.RequiredCourseCategory);
            }
        }

        public async Task MustBeOrganizationDefined(int organizationId)
        {
            var result = await _organizationDal.GetListAsync(
                predicate: p => p.Id == organizationId
                );
            if (result.Count == 0)
            {
                throw new BusinessException(BusinessMessages.RequiredOrganization);
            }
        }

        public async Task LanguageCantBeNull(string language)
        {
            if (string.IsNullOrEmpty(language))
            {
                throw new BusinessException(BusinessMessages.NotNullableLanguage);
            }
        }

        public async Task SubTypeCantBeNull(string subType)
        {
            if (string.IsNullOrEmpty(subType))
            {
                throw new BusinessException(BusinessMessages.NotNullableSubType);
            }
        }
    }
}
