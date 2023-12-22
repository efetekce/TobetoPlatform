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
    public class CourseContentTypeBusinessRules : BaseBusinessRules
    {
        private readonly ICourseContentTypeDal _courseContentTypeDal;

        public CourseContentTypeBusinessRules(ICourseContentTypeDal courseContentTypeDal)
        {
            _courseContentTypeDal = courseContentTypeDal;
        }

        public async Task ContentTypeNameCantBeNull(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new BusinessException(BusinessMessages.NotNullableContentTypeName);
            }
        }
    }
}
