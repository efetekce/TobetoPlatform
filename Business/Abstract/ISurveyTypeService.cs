using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;

namespace Business.Abstract
{
    public interface ISurveyTypeService
    {
        Task<CreatedSurveyTypeResponse> Add(CreateSurveyTypeRequest createSurveyTypeRequest);
        Task<UpdatedSurveyTypeResponse> Update(UpdateSurveyTypeRequest updateSurveyTypeRequest);
        Task<DeletedSurveyTypeResponse> Delete(DeleteSurveyTypeRequest deleteSurveyTypeRequest);
        Task<IPaginate<GetListSurveyTypeResponse>> GetListSurveyType();
    }
}
