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
    public interface ISkillService
    {
        Task<IPaginate<GetListSkillResponse>> GetListSkillInformation();
        Task<CreatedSkillsResponse> Add(CreateSkillRequest createSkillRequest);
        Task<UpdatedSkillsResponse> Update(UpdateSkillsRequest updateSkillsRequest);
        Task<DeletedSkillsResponse> Delete(DeleteSkillsRequest deleteSkillsRequest);
    }
}
