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
    public class AccountCourseLessonMappingProfile : Profile
    {
        public AccountCourseLessonMappingProfile()
        {
            CreateMap<CreateAccountCourseLessonRequest, AccountCourseLesson>().ReverseMap();
            CreateMap<UpdateAccountCourseLessonRequest, AccountCourseLesson>().ReverseMap();
            CreateMap<DeleteAccountCourseLessonRequest, AccountCourseLesson>().ReverseMap();

            CreateMap<AccountCourseLesson, GetListAccountCourseLessonResponse>().ReverseMap();
            CreateMap<Paginate<AccountCourseLesson>, Paginate<GetListAccountCourseLessonResponse>>().ReverseMap();

            CreateMap<AccountCourseLesson, CreatedAccountCourseLessonResponse>().ReverseMap();
            CreateMap<AccountCourseLesson, UpdatedAccountCourseLessonResponse>().ReverseMap();
            CreateMap<AccountCourseLesson, DeletedAccountCourseLessonResponse>().ReverseMap();
        }
    }
}
