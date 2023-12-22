using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;

namespace Business.Abstract
{
    public interface IApplicationStatusService
    {
        Task<CreatedApplicationStatusResponse> Add(CreateApplicationStatusRequest createApplicationStatusRequest);
        Task<UpdatedApplicationStatusResponse> Update(UpdateApplicationStatusRequest updateApplicationStatusRequest);
        Task<DeletedApplicationStatusResponse> Delete(DeleteApplicationStatusRequest deleteApplicationStatusRequest);
        Task<IPaginate<GetListApplicationStatusResponse>> GetListApplicationStatus(PageRequest pageRequest);
    }
}
