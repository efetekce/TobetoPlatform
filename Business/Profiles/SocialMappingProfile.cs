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
    public class SocialMappingProfile : Profile
    {
        public SocialMappingProfile()
        {
            CreateMap<CreateSocialMediaRequest, SocialMedia>().ReverseMap();
            CreateMap<UpdateSocialMediaRequest, SocialMedia>().ReverseMap();
            CreateMap<DeleteSocialMediaRequest, SocialMedia>().ReverseMap();
        
            CreateMap<Paginate<SocialMedia>, Paginate<GetListSocialMediaResponse>>().ReverseMap();

            CreateMap<SocialMedia, GetListSocialMediaResponse>().ReverseMap();
            CreateMap<SocialMedia, UpdatedSocialMediaResponse>().ReverseMap();
            CreateMap<SocialMedia, DeletedSocialMediaResponse>().ReverseMap();
        }
       
    }
}
