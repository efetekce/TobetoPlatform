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
    public class AccountExperienceMappingProfile : Profile
    {
        public AccountExperienceMappingProfile()
        {
            CreateMap<CreateAccountExperienceRequest, AccountExperience>().ReverseMap();
            CreateMap<AccountExperience, CreatedAccountExperienceResponse>()
            .ForMember(dest => dest.AccountId, opt => opt.MapFrom(src => src.Account.Id))
            .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.City.Id))
            .ReverseMap();

            CreateMap<DeleteAccountExperienceRequest, AccountExperience>().ReverseMap();
            CreateMap<AccountExperience, DeletedAccountExperienceResponse>()
            .ForMember(dest => dest.AccountId, opt => opt.MapFrom(src => src.Account.Id))
            .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.City.Id))
            .ReverseMap();
            
            CreateMap<Paginate<AccountExperience>, Paginate<GetListAccountExperienceResponse>>().ReverseMap();
            CreateMap<AccountExperience, GetListAccountExperienceResponse>()
            .ForMember(dest => dest.AccountId, opt => opt.MapFrom(src => src.Account.Id))
            .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.City.Id))
            .ReverseMap();
            
            CreateMap<UpdateAccountExperienceRequest, AccountExperience>().ReverseMap();
            CreateMap<AccountExperience, UpdatedAccountExperienceResponse>()
            .ForMember(dest => dest.AccountId, opt => opt.MapFrom(src => src.Account.Id))
            .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.City.Id))
            .ReverseMap();
        }
    }
}
