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
            CreateMap<CreateLanguageRequest, ForeignLanguage>().ReverseMap();
            CreateMap<UpdateLanguageRequest, ForeignLanguage>().ReverseMap();
            CreateMap<DeletedLanguageRequest, ForeignLanguage>().ReverseMap();

            CreateMap<ForeignLanguage, GetListLanguageResponse>().ReverseMap();
            CreateMap<Paginate<ForeignLanguage>, Paginate<GetListLanguageResponse>>().ReverseMap();

            CreateMap<ForeignLanguage, CreatedLanguageResponse>().ReverseMap();
            CreateMap<ForeignLanguage, UpdatedLanguageResponse>().ReverseMap();
            CreateMap<ForeignLanguage, DeletedLanguageResponse>().ReverseMap();


        }
    }

}
