using Core.Business.Rules;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class AccountPasswordBusinessRules:BaseBusinessRules
    {
        private readonly IAccountPasswordDal _accountPasswordDal;
        public AccountPasswordBusinessRules(IAccountPasswordDal accountPasswordDal)
        {
            _accountPasswordDal = accountPasswordDal;
        }
    }
}
