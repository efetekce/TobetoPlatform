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

    public class AnswerMappingProfile : Profile
    {
        public AnswerMappingProfile()
        {
            CreateMap<CreateAnswerRequest, Answer>().ReverseMap();
            CreateMap<UpdateAnswerRequest, Answer>().ReverseMap();
            CreateMap<DeleteAnswerRequest, Answer>().ReverseMap();

            CreateMap<Answer, GetListAnswerResponse>().ReverseMap();
            CreateMap<Paginate<Answer>, Paginate<GetListAnswerResponse>>().ReverseMap();
            CreateMap<CreatedAnswerResponse, Answer>().ReverseMap();

            CreateMap<Answer, UpdatedAnswerResponse>().ReverseMap();
            CreateMap<Answer, DeletedAnswerResponse>().ReverseMap();
        }
    }
}

