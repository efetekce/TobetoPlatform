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
    public class SurveyTypeMappingProfile:Profile
    {
        public SurveyTypeMappingProfile()
        {
            CreateMap<CreateSurveyTypeRequest, SurveyType>().ReverseMap();
            CreateMap<UpdateSurveyTypeRequest, SurveyType>().ReverseMap();
            CreateMap<DeleteSurveyTypeRequest, SurveyType>().ReverseMap();

            CreateMap<SurveyType, CreatedSurveyTypeResponse>().ReverseMap();
            CreateMap<SurveyType, UpdatedSurveyTypeResponse>().ReverseMap();
            CreateMap<SurveyType, DeletedSurveyTypeResponse>().ReverseMap();

            CreateMap<SurveyType, GetListSurveyTypeResponse>().ReverseMap();
            CreateMap<Paginate<SurveyType>, Paginate<GetListSurveyTypeResponse>>().ReverseMap();
        }
    }
}
