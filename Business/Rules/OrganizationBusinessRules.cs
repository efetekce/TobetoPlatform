using Core.Business.Rules;
using Business.Constants.Messages;
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
    public class OrganizationBusinessRules : BaseBusinessRules
    {
        private readonly IOrganizationDal _organizationDal;
        private readonly IAddressDal _addressDal;
        public OrganizationBusinessRules(IOrganizationDal organizationDal, IAddressDal addressDal)
        {
            _organizationDal = organizationDal;
            _addressDal = addressDal;
        }

        public async Task OrganizationNameCantBeNull(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new BusinessException(BusinessMessages.NotNullableOrganizationName);
            }
        }

        public async Task ContactNumberCantBeNull(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new BusinessException(BusinessMessages.NotNullableContactNumber);
            }
        }

        public async Task MustBeAddressDefined(int addressId)
        {
            var result = await _addressDal.GetListAsync(
                predicate: p => p.Id == addressId
                );
            if (result.Count == 0)
            {
                throw new BusinessException(BusinessMessages.RequiredAddress);
            }
        }
    }
}
