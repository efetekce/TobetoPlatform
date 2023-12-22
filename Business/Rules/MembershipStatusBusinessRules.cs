using Core.Business.Rules;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class MembershipStatusBusinessRules:BaseBusinessRules
    {
        private readonly IMembershipStatusDal _membershipStatusDal;
        public MembershipStatusBusinessRules(IMembershipStatusDal membershipStatusDal)
        {
            _membershipStatusDal = membershipStatusDal;
        }
    }
}
