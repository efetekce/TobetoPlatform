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
    public class AccountPasswordMappingProfile:Profile
    {
        public AccountPasswordMappingProfile()
        {
            CreateMap<CreateAccountPasswordRequest, AccountPassword>().ReverseMap();
            CreateMap<UpdateAccountPasswordRequest, AccountPassword>().ReverseMap();
            CreateMap<DeleteAccountPasswordRequest, AccountPassword>().ReverseMap();

            CreateMap<AccountPassword, CreatedAccountPasswordResponse>().ReverseMap();
            CreateMap<AccountPassword, UpdatedAccountPasswordResponse>().ReverseMap();
            CreateMap<AccountPassword, DeletedAccountPasswordResponse>().ReverseMap();

            CreateMap<AccountPassword,GetListAccountPasswordResponse>().ReverseMap();
            CreateMap<Paginate<AccountPassword>,Paginate<GetListAccountPasswordResponse>>().ReverseMap();
        }
    }
}
