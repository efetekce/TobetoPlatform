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
    public interface IAccountExperienceService
    {
        Task<CreatedExperienceResponse> Add(CreateAccountExperienceRequest createExperienceRequest);

        Task<IPaginate<GetListExperienceResponse>> GetListExperience(PageRequest pageRequest);

        Task<UpdatedExperienceResponse> Update(UpdateAccountExperienceRequest updateExperienceRequest);

        Task<DeletedExperienceResponse> Delete(DeleteAccountExperienceRequest deleteExperienceRequest);
    }
}
