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
            CreateMap<UpdateAccountExperienceRequest, AccountExperience>().ReverseMap();
            CreateMap<DeleteAccountExperienceRequest, AccountExperience>().ReverseMap();
            CreateMap<Paginate<AccountExperience>, Paginate<GetListExperienceResponse>>().ReverseMap();
            CreateMap<AccountExperience, CreatedExperienceResponse>().ReverseMap();
            CreateMap<AccountExperience, UpdatedExperienceResponse>().ReverseMap();
            CreateMap<AccountExperience, DeletedExperienceResponse>().ReverseMap();
            CreateMap<AccountExperience, GetListExperienceResponse>().ReverseMap();
        }
    }
}
