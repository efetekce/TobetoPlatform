using Business.Messages;
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
    public class OrganizationBusinessRules : BaseBusinessRules
    {
        private readonly IOrganizationDal _organizationDal;
        public OrganizationBusinessRules(IOrganizationDal organizationDal)
        {
            _organizationDal = organizationDal;
        }

        public async Task OrganizationRule()
        {
           
        }
    }
}
