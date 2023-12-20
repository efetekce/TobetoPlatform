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
    public class SkillsMappingProfile : Profile
    {
        public SkillsMappingProfile()
        {
            CreateMap<CreatedSkillsRequest, Skills>().ReverseMap();
            CreateMap<UpdateSkillsRequest, Skills>().ReverseMap();
            CreateMap<DeletedSkillsRequest, Skills>().ReverseMap();



            CreateMap<Paginate<Skills>, Paginate<GetListSkillsResponse>>().ReverseMap();

            CreateMap<Skills, GetListSkillsResponse>().ReverseMap();
            CreateMap<Skills, UpdatedSkillsResponse>().ReverseMap();
            CreateMap<Skills, DeletedSkillsResponse>().ReverseMap();
        }
    }
}
