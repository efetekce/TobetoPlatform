using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISurveyService
    {
        Task<CreatedSurveyResponse> Add(CreateSurveyRequest createSurveyRequest);
        Task<UpdatedSurveyResponse> Update(UpdateSurveyRequest updateSurveyRequest);
        Task<DeletedSurveyResponse> Delete(DeleteSurveyRequest deleteSurveyRequest);
        Task<IPaginate<GetListSurveyResponse>> GetListSurvey();
    }
}
