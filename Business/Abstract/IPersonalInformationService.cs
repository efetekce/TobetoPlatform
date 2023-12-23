using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonalInformationService
    {
        Task<IPaginate<GetListPersonalInformationResponse>> GetListPersonalInformation(PageRequest pageRequest);
        Task<CreatedPersonalInformationResponse> Add(CreatePersonalInformationRequest createPersonalInformationRequest);
        Task<UpdatedPersonalInformationResponse> Update(UpdatePersonalInformationRequest updatePersonalInformationRequest);
        Task<DeletedPersonalInformationResponse> Delete(DeletePersonalInformationRequest deletePersonalInformationRequest);       
    }
}
