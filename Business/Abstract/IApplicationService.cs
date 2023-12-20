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
    public interface IApplicationService
    {
        Task<CreatedApplicationResponse> Add(CreateApplicationRequest createApplicationRequest);
        Task<UpdatedApplicationResponse> Update(UpdateApplicationRequest updateApplicationRequest);
        Task<DeletedApplicationResponse> Delete(DeleteApplicationRequest deleteApplicationRequest);
        Task<IPaginate<GetListApplicationResponse>> GetListApplication();
    }
}
