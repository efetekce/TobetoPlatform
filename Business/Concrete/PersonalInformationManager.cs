using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonalInformationManager : IPersonalInformationService
    {
        IPersonalInformationDal _personalInformationDal;
        IMapper _mapper;

        public PersonalInformationManager(IPersonalInformationDal personalInformationDal, IMapper mapper)
        {
            _personalInformationDal = personalInformationDal;
            _mapper = mapper;
        }

        public async Task<CreatedPersonalInformationResponse> Add(CreatePersonalInformationRequest createPersonalInformationRequest)
        {
            PersonalInformation personalInformation = _mapper.Map<PersonalInformation>(createPersonalInformationRequest);
            PersonalInformation createdPersonalInformation = await _personalInformationDal.AddAsync(personalInformation);
            CreatedPersonalInformationResponse createdPersonalInformationResponse = _mapper.Map<CreatedPersonalInformationResponse>(createdPersonalInformation);
            return createdPersonalInformationResponse;
        }

        public async Task<DeletedPersonalInformationResponse> Delete(DeletePersonalInformationRequest deletePersonalInformationRequest)
        {
            PersonalInformation personalInformation = _mapper.Map<PersonalInformation>(deletePersonalInformationRequest);
            var deletedPersonalInformation = await _personalInformationDal.DeleteAsync(personalInformation, true);
            DeletedPersonalInformationResponse deletedPersonalInformationResponse = _mapper.Map<DeletedPersonalInformationResponse>(deletedPersonalInformation);
            return deletedPersonalInformationResponse;
        }

        public async Task<IPaginate<GetListPersonalInformationResponse>> GetListPersonalInformation(PageRequest pageRequest)
        {
            var data = await _personalInformationDal.GetListAsync(
                orderBy: p => p.OrderBy(p => p.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var responseList = _mapper.Map<Paginate<GetListPersonalInformationResponse>>(data);
            return responseList;
        }

        public async Task<UpdatedPersonalInformationResponse> Update(UpdatePersonalInformationRequest updatePersonalInformationRequest)
        {
            PersonalInformation personalInformation = _mapper.Map<PersonalInformation>(updatePersonalInformationRequest);
            var updatedPersonalInformation = await _personalInformationDal.UpdateAsync(personalInformation);
            UpdatedPersonalInformationResponse updatedPersonalInformationResponse = _mapper.Map<UpdatedPersonalInformationResponse>(updatedPersonalInformation);
            return updatedPersonalInformationResponse;
        }
    }
}
