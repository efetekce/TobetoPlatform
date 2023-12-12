using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
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
    }
}
