using Core.Business.Rules;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class SurveyBusinessRules:BaseBusinessRules
    {
        private readonly ISurveyDal _surveyDal;
        public SurveyBusinessRules(ISurveyDal surveyDal)
        {
            _surveyDal = surveyDal;
        }

    }
}
