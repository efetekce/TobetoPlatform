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
    public class CourseCategoryMappingProfile:Profile
    {
        public CourseCategoryMappingProfile()
        {
            CreateMap<CreateCourseCategoryRequest, CourseCategory>().ReverseMap();
            CreateMap<UpdateCourseCategoryRequest, CourseCategory>().ReverseMap();
            CreateMap<DeleteCourseCategoryRequest, CourseCategory>().ReverseMap();

            CreateMap<CourseCategory, GetListCourseCategoryResponse>().ReverseMap();
            CreateMap<Paginate<CourseCategory>, Paginate<GetListCourseCategoryResponse>>().ReverseMap();

            CreateMap<CourseCategory, CreatedAccountResponse>().ReverseMap();
            CreateMap<CourseCategory, UpdatedAccountResponse>().ReverseMap();
            CreateMap<CourseCategory, DeletedAccountResponse>().ReverseMap();
        }
    }
}
