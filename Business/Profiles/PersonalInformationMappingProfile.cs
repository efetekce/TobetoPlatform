using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Response;
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
            CreateMap<CreatePersonalInformationRequest, PersonalInformation>().ReverseMap();
            CreateMap<CreatedPersonalInformationResponse, PersonalInformation>().ReverseMap();
        }
    }
}
