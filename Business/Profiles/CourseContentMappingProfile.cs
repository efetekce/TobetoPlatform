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
    public class CourseContentMappingProfile : Profile
    {
        public CourseContentMappingProfile()
        {
            CreateMap<CreateCourseContentRequest, CourseContent>().ReverseMap();
            CreateMap<UpdateCourseContentRequest, CourseContent>().ReverseMap();
            CreateMap<DeleteCourseContentRequest, CourseContent>().ReverseMap();

            CreateMap<CourseContent, GetListCourseContentResponse>().ReverseMap();
            CreateMap<Paginate<CourseContent>,Paginate<GetListCourseContentResponse>>().ReverseMap();

            CreateMap<CourseContent, CreatedCourseContentResponse>().ReverseMap();
            CreateMap<CourseContent, UpdatedCourseContentResponse>().ReverseMap();
            CreateMap<CourseContent, DeletedCourseContentResponse>().ReverseMap();
        }
    }
}
