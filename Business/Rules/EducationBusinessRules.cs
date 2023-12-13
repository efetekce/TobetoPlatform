using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class EducationBusinessRules
    {
        private readonly IEducationDal _educationDal;
        public EducationBusinessRules(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public async Task MaximumEducationCountIsTen()
        {

        }
    }
}
