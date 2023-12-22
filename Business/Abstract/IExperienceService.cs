using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IExperienceService
    {
        Task<CreatedExperienceResponse> Add(CreateExperienceRequest createExperienceRequest);

        Task<IPaginate<GetListExperienceResponse>> GetListExperience(PageRequest pageRequest);

        Task<UpdatedExperienceResponse> Update(UpdateExperienceRequest updateExperienceRequest);

        Task<DeletedExperienceResponse> Delete(DeleteExperienceRequest deleteExperienceRequest);
    }
}
