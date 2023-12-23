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
    public interface IMembershipStatusService
    {
        Task<IPaginate<GetListMembershipStatusResponse>> GetListMembershipStatus(PageRequest pageRequest);
        Task<CreatedMembershipStatusResponse> Add(CreateMembershipStatusRequest createMembershipStatusRequest);
        Task<UpdatedMembershipStatusResponse> Update(UpdateMembershipStatusRequest updateMembershipStatusRequest);
        Task<DeletedMembershipStatusResponse> Delete(DeleteMembershipStatusRequest deleteMembershipStatusRequest);
    }
}
