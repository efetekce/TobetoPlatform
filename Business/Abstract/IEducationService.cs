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
    public interface IEducationService
    {
        Task<CreatedEducationResponse> Add(CreateEducationRequest createEducationRequest);

        Task<IPaginate<GetListEducationResponse>> GetListEducation();

        Task<UpdatedEducationResponse> Update(UpdateEducationRequest updateEducationRequest);

        Task<DeletedEducationResponse> Delete(DeleteEducationRequest deleteEducationRequest);
    }
}
