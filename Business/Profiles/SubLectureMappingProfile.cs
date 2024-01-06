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
    public class SubLectureMappingProfile:Profile
    {
        public SubLectureMappingProfile()
        {
            CreateMap<CreateSubLectureRequest, SubLecture>().ReverseMap();
            CreateMap<UpdateSubLectureRequest, SubLecture>().ReverseMap();
            CreateMap<DeleteSubLectureRequest, SubLecture>().ReverseMap();

            CreateMap<SubLecture, GetListSubLectureResponse>().ReverseMap();
            CreateMap<Paginate<SubLecture>, Paginate<GetListSubLectureResponse>>().ReverseMap();

            CreateMap<SubLecture, CreatedSubLectureResponse>().ReverseMap();
            CreateMap<SubLecture, UpdatedSubLectureResponse>().ReverseMap();
            CreateMap<SubLecture, DeletedSubLectureResponse>().ReverseMap();
        }
    }
}
