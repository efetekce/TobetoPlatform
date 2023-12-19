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
        public class SkillMappingProfile : Profile
        {
            public SkillMappingProfile()
            {
                CreateMap<CreateSkillRequest, Skill>().ReverseMap();
                CreateMap<UpdateSkillsRequest, Skill>().ReverseMap();
                CreateMap<DeleteSkillsRequest, Skill>().ReverseMap();

                CreateMap<Skill, GetListSkillResponse>().ReverseMap();
                CreateMap<Paginate<Skill>, Paginate<GetListSkillResponse>>().ReverseMap();
                CreateMap<Skill, CreatedSkillsResponse>().ReverseMap();


                CreateMap<Skill, UpdatedSkillsResponse>().ReverseMap();
                CreateMap<Skill, DeletedSkillsResponse>().ReverseMap();
            }
        }
    
}
