using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class CourseBusinessRules : BaseBusinessRules
    {
        private readonly ICourseDal _courseDal;

        public CourseBusinessRules(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public async Task CourseNameCantBeNull(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new BusinessException(BusinessMessages.NotNullableCourseName);
            }
        }

        public async Task ImagePathCantBeNull(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                throw new BusinessException(BusinessMessages.NotNullableImagePath);
            }
        }

      
    }
}
