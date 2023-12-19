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
    public interface ISessionStatusService
    {
        Task<IPaginate<GetListSessionStatusResponse>> GetListSessionStatus();
        Task<CreatedSessionStatusResponse> Add(CreateSessionStatusRequest createSessionStatusRequest);
        Task<UpdatedSessionStatusResponse> Update(UpdateSessionStatusRequest updateSessionStatusRequest);
        Task<DeletedSessionStatusResponse> Delete(DeleteSessionStatusRequest deleteSessionStatusRequest);
    }
}
