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
    public class LanguageMappingProfile : Profile
    {
        public LanguageMappingProfile()
        {
            CreateMap<CreateLanguageRequest, Language>().ReverseMap();
            CreateMap<UpdateLanguageRequest, Language>().ReverseMap();
            CreateMap<DeletedLanguageRequest, Language>().ReverseMap();

            CreateMap<Language, GetListLanguageResponse>().ReverseMap();
            CreateMap<Paginate<Language>, Paginate<GetListLanguageResponse>>().ReverseMap();

            CreateMap<Language, CreatedLanguageResponse>().ReverseMap();
            CreateMap<Language, UpdatedLanguageResponse>().ReverseMap();
            CreateMap<Language, DeletedLanguageResponse>().ReverseMap();



        }
    }
}
