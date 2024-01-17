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
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => $"{src.Country.Code} {src.PhoneNumber}"))
            .ReverseMap();

            CreateMap<UpdateAccountRequest, Account>()
            .ReverseMap();
            CreateMap<Account, UpdatedAccountResponse>()
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => $"{src.Country.Code} {src.PhoneNumber}"))
            .ReverseMap();

            CreateMap<DeleteAccountRequest, Account>().ReverseMap();
            CreateMap<Account, DeletedAccountResponse>().ReverseMap();

            CreateMap<Account, GetListAccountResponse>()
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => $"{src.Country.Code} {src.PhoneNumber}"))
            .ReverseMap();
            CreateMap<Paginate<Account>, Paginate<GetListAccountResponse>>().ReverseMap();

            CreateMap<GetByIdAccountRequest, Account>().ReverseMap();
        }
    }
}
