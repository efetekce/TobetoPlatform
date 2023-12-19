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
    public class EducationMappingProfile : Profile
    {
        public EducationMappingProfile()
        {
            CreateMap<CreateEducationRequest, Education>().ReverseMap();
            CreateMap<UpdateEducationRequest, Education>().ReverseMap();
            CreateMap<DeleteEducationRequest, Education>().ReverseMap();

            CreateMap<Education, CreatedEducationResponse>().ReverseMap();
            CreateMap<Education, UpdatedEducationResponse>().ReverseMap();
            CreateMap<Education, DeletedEducationResponse>().ReverseMap();
            CreateMap<Paginate<Education>, Paginate<GetListEducationResponse>>().ReverseMap();
            CreateMap<Education, GetListEducationResponse>().ReverseMap();
        }
    }
}
