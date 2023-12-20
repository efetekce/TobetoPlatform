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

    public class QuestionCategoryMappingProfile : Profile
    {
        public QuestionCategoryMappingProfile()
        {
            CreateMap<CreateQuestionCategoryRequest, QuestionCategory>().ReverseMap();
            CreateMap<UpdateQuestionCategoryRequest, QuestionCategory>().ReverseMap();
            CreateMap<DeleteQuestionCategoryRequest, QuestionCategory>().ReverseMap();

            CreateMap<QuestionCategory, GetListQuestionCategoryResponse>().ReverseMap();
            CreateMap<Paginate<QuestionCategory>, Paginate<GetListQuestionCategoryResponse>>().ReverseMap();
            CreateMap<CreatedQuestionCategoryResponse, QuestionCategory>().ReverseMap();

            CreateMap<QuestionCategory, UpdatedQuestionCategoryResponse>().ReverseMap();
            CreateMap<QuestionCategory, DeletedQuestionCategoryResponse>().ReverseMap();
        }
    }
}

