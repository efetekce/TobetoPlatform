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
    public class AccountMappingProfile : Profile
    {
        public AccountMappingProfile()
        {
            CreateMap<CreateAccountRequest, Account>().ReverseMap();
            CreateMap<Account, CreatedAccountResponse>()
            //.ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.Country.Id))
            //.ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.City.Id))
            //.ForMember(dest => dest.DistrictId, opt => opt.MapFrom(src => src.District.Id))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => $"{src.Country.Code} {src.PhoneNumber}"))
            .ReverseMap();

            CreateMap<UpdateAccountRequest, Account>().ReverseMap();
            CreateMap<Account, UpdatedAccountResponse>()
            //.ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => $"{src.Country.Code} {src.PhoneNumber}"))
            //.ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.Country.Id))
            //.ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.City.Id))
            //.ForMember(dest => dest.DistrictId, opt => opt.MapFrom(src => src.District.Id))
            .ReverseMap();

            CreateMap<DeleteAccountRequest, Account>().ReverseMap();
            CreateMap<Account, DeletedAccountResponse>()
            //.ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => $"{src.Country.Code} {src.PhoneNumber}"))
            //.ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.Country.Id))
            //.ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.City.Id))
            //.ForMember(dest => dest.DistrictId, opt => opt.MapFrom(src => src.District.Id))
            .ReverseMap();

            CreateMap<Paginate<Account>, Paginate<GetListAccountResponse>>().ReverseMap();
            CreateMap<Account, GetListAccountResponse>()
            //.ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => $"{src.Country.Code} {src.PhoneNumber}"))
            //.ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.Country.Id))
            //.ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.City.Id))
            //.ForMember(dest => dest.DistrictId, opt => opt.MapFrom(src => src.District.Id))
            .ReverseMap();
            

            CreateMap<GetByIdAccountRequest, Account>()
            //.ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => $"{src.Country.Code} {src.PhoneNumber}"))
            //.ForMember(dest => dest.CountryName, opt => opt.MapFrom(src => $"{src.Country.Name}"))
            //.ForMember(dest => dest.CityName, opt => opt.MapFrom(src => $"{src.City.Name}"))
            //.ForMember(dest => dest.DistrictName, opt => opt.MapFrom(src => $"{src.District.Name}"))
            .ReverseMap();
        }
    }
}
