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
    public class CourseDetailMappingProfile : Profile
    {
        public CourseDetailMappingProfile()
        {
            CreateMap<CreateCourseDetailRequest, CourseDetail>().ReverseMap();
            CreateMap<UpdateCourseDetailRequest, CourseDetail>().ReverseMap();
            CreateMap<DeleteCourseDetailRequest, CourseDetail>().ReverseMap();

            CreateMap<CourseDetail, GetListCourseDetailResponse>().ReverseMap();
            CreateMap<Paginate<CourseDetail>, Paginate<GetListCourseDetailResponse>>().ReverseMap();

            CreateMap<CourseDetail, CreatedCourseDetailResponse>().ReverseMap();
            CreateMap<CourseDetail, UpdatedCourseDetailResponse>().ReverseMap();
            CreateMap<CourseDetail, DeletedCourseDetailResponse>().ReverseMap();
        }
    }
}
