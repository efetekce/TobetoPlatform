using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class PersonalInformationMappingProfile :Profile
    {
        public PersonalInformationMappingProfile()
        {
            CreateMap<IPaginate<PersonalInformation>, Paginate<GetListPersonalInformationResponse>>().ReverseMap();
            CreateMap<GetListPersonalInformationResponse, PersonalInformation>().ReverseMap();

            CreateMap<CreatePersonalInformationRequest, PersonalInformation>().ReverseMap();
            CreateMap<CreatedPersonalInformationResponse, PersonalInformation>().ReverseMap();

            CreateMap<UpdatePersonalInformationRequest, PersonalInformation>().ReverseMap();
            CreateMap<UpdatedPersonalInformationResponse, PersonalInformation>().ReverseMap();

            CreateMap<DeletePersonalInformationRequest, PersonalInformation>().ReverseMap();
            CreateMap<DeletedPersonalInformationResponse, PersonalInformation>().ReverseMap();
        }
    }
}
