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
    public class CourseContentTypeMappingProfile:Profile
    {
        public CourseContentTypeMappingProfile()
        {
            CreateMap<CreateCourseContentTypeRequest, CourseContentType>().ReverseMap();
            CreateMap<UpdateCourseContentTypeRequest, CourseContentType>().ReverseMap();
            CreateMap<DeleteCourseContentTypeRequest, CourseContentType>().ReverseMap();

            CreateMap<CourseContentType, GetListCourseContentTypeResponse>().ReverseMap();
            CreateMap<Paginate<CourseContentType>, Paginate<GetListCourseContentTypeResponse>>().ReverseMap();

            CreateMap<CourseContentType, CreatedCourseContentTypeResponse>().ReverseMap();
            CreateMap<CourseContentType, UpdatedCourseContentTypeResponse>().ReverseMap();
            CreateMap<CourseContentType, DeletedCourseContentTypeResponse>().ReverseMap();
        }
    }
}
