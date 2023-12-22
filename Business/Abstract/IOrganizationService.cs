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
    public interface IOrganizationService
    {
        Task<CreatedOrganizationResponse> Add(CreateOrganizationRequest createOrganizationRequest);
        Task<UpdatedOrganizationResponse> Update(UpdateOrganizationRequest updateOrganizationRequest);
        Task<DeletedOrganizationResponse> Delete(DeleteOrganizationRequest deleteOrganizationRequest);
        Task<IPaginate<GetListOrganizationResponse>> GetListOrganization(PageRequest pageRequest);
    }
}
