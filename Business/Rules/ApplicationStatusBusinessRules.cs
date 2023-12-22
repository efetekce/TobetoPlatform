using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules
{
    public class ApplicationStatusBusinessRules:BaseBusinessRules
    {
        private readonly IApplicationStatusDal _applicationStatusDal;
        public ApplicationStatusBusinessRules(IApplicationStatusDal applicationStatusDal)
        {
            _applicationStatusDal = applicationStatusDal;
        }
    }
}
