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
    public interface ISkillsService
    {
        Task<CreatedSkillsResponse> Add(CreatedSkillsRequest createSkillsRequest);
        Task<IPaginate<GetListSkillsResponse>> GetListSkills();
        Task<UpdatedSkillsResponse> Update(UpdateSkillsRequest updateSkillsRequest);
        Task<DeletedSkillsResponse> Delete(DeletedSkillsRequest deleteCategoryRequest);
    }
}
