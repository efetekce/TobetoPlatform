using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class AccountApplicationMappingProfile:Profile
    {
        public AccountApplicationMappingProfile()
        {
            CreateMap<CreateAccountApplicationRequest, AccountApplication>().ReverseMap();
            CreateMap<UpdateAccountApplicationRequest, AccountApplication>().ReverseMap();
            CreateMap<DeleteAccountApplicationRequest, AccountApplication>().ReverseMap();

            CreateMap<AccountApplication, CreatedAccountApplicationResponse>().ReverseMap();
            CreateMap<AccountApplication, UpdatedAccountApplicationResponse>().ReverseMap();
            CreateMap<AccountApplication, DeletedAccountApplicationResponse>().ReverseMap();

            CreateMap<AccountApplication, GetListAccountApplicationResponse>().ReverseMap();
            CreateMap<Paginate<AccountApplication>, Paginate<GetListAccountApplicationResponse>>().ReverseMap();
        }
    }
}
