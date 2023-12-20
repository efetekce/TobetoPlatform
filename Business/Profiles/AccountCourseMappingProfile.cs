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
    public class AccountCourseMappingProfile : Profile
    {
        public AccountCourseMappingProfile()
        {
            CreateMap<CreateAccountCourseRequest, AccountCourse>().ReverseMap();
            CreateMap<UpdateAccountCourseRequest, AccountCourse>().ReverseMap();
            CreateMap<DeleteAccountCourseRequest, AccountCourse>().ReverseMap();

            CreateMap<AccountCourse, GetListAccountCourseResponse>().ReverseMap();
            CreateMap<Paginate<AccountCourse>, Paginate<GetListAccountCourseResponse>>().ReverseMap();

            CreateMap<AccountCourse, CreatedAccountCourseResponse>().ReverseMap();
            CreateMap<AccountCourse, UpdatedAccountCourseResponse>().ReverseMap();
            CreateMap<AccountCourse, DeletedAccountCourseResponse>().ReverseMap();
        }
    }
}
