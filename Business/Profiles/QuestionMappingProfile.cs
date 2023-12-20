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

    public class QuestionMappingProfile : Profile
    {
        public QuestionMappingProfile()
        {
            CreateMap<CreateQuestionRequest, Question>().ReverseMap();
            CreateMap<UpdateQuestionRequest, Question>().ReverseMap();
            CreateMap<DeleteQuestionRequest, Question>().ReverseMap();

            CreateMap<Question, GetListQuestionResponse>().ReverseMap();
            CreateMap<Paginate<Question>, Paginate<GetListQuestionResponse>>().ReverseMap();
            CreateMap<CreatedQuestionResponse, Question>().ReverseMap();

            CreateMap<Question, UpdatedQuestionResponse>().ReverseMap();
            CreateMap<Question, DeletedQuestionResponse>().ReverseMap();
        }
    }
}

