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

namespace Business.Dtos.Profiles
{
    public class ExperienceMappingProfile : Profile
    {
        public ExperienceMappingProfile()
        {         
            CreateMap<CreateExperienceRequest, Experience>().ReverseMap();
            CreateMap<UpdateExperienceRequest, Experience>().ReverseMap();
            CreateMap<DeleteExperienceRequest, Experience>().ReverseMap();
            CreateMap<Paginate<Experience>, Paginate<GetListExperienceResponse>>().ReverseMap();
            CreateMap<Experience, CreatedExperienceResponse>().ReverseMap();
            CreateMap<Experience, UpdatedExperienceResponse>().ReverseMap();
            CreateMap<Experience, DeletedExperienceResponse>().ReverseMap();
            CreateMap<Experience, GetListExperienceResponse>().ReverseMap();
        }
    }
}
