using Core.Business.Rules;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class SessionStatusBusinessRules:BaseBusinessRules
    {
        private readonly ISessionStatusDal _sessionStatusDal;
        public SessionStatusBusinessRules(ISessionStatusDal sessionStatusDal)
        {
            _sessionStatusDal = sessionStatusDal;
        }

    }
}
