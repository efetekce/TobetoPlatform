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

    public class AssessmentMappingProfile : Profile
    {
        public AssessmentMappingProfile()
        {
            CreateMap<CreateAssessmentRequest, Assessment>().ReverseMap();
            CreateMap<UpdateAssessmentRequest, Assessment>().ReverseMap();
            CreateMap<DeleteAssessmentRequest, Assessment>().ReverseMap();

            CreateMap<Assessment, GetListAssessmentResponse>().ReverseMap();
            CreateMap<Paginate<Assessment>, Paginate<GetListAssessmentResponse>>().ReverseMap();
            CreateMap<CreatedAssessmentResponse, Assessment>().ReverseMap();

            CreateMap<Assessment, UpdatedAssessmentResponse>().ReverseMap();
            CreateMap<Assessment, DeletedAssessmentResponse>().ReverseMap();
        }
    }
}

