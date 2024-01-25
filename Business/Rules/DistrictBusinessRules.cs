using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class DistrictBusinessRules : BaseBusinessRules
    {
        private readonly IDistrictDal _districtDal;
        public DistrictBusinessRules(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public async Task SameDistrictName(string name, int cityId)
        {
            var result = await _districtDal.GetListAsync(d => d.Name == name && d.Id == cityId);
            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameDistrictNameError);
            }
        }
    }
}
