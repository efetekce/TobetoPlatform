using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;

namespace Business.Abstract
{
    public interface IApplicationStepService
    {
        Task<CreatedApplicationStepResponse> Add(CreateApplicationStepRequest createApplicationStepRequest);
        Task<UpdatedApplicationStepResponse> Update(UpdateApplicationStepRequest updateApplicationStepRequest);
        Task<DeletedApplicationStepResponse> Delete(DeleteApplicationStepRequest deleteApplicationStepRequest);
        Task<IPaginate<GetListApplicationStepResponse>> GetListApplicationStep(PageRequest pageRequest);
    }
}
