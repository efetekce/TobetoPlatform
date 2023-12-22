using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules
{
    public class SurveyTypeBusinessRules:BaseBusinessRules
    {
        private readonly ISurveyTypeDal _surveyTypeDal;
        public SurveyTypeBusinessRules(ISurveyTypeDal surveyTypeDal)
        {
            _surveyTypeDal = surveyTypeDal;
        }

    }
}
