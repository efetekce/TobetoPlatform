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
    public class ApplicationMappingProfile:Profile
    {
        public ApplicationMappingProfile()
        {
            CreateMap<CreateApplicationRequest, Application>().ReverseMap();
            CreateMap<UpdateApplicationRequest, Application>().ReverseMap();
            CreateMap<DeleteApplicationRequest, Application>().ReverseMap();

            CreateMap<Application, CreatedApplicationResponse>().ReverseMap();
            CreateMap<Application, UpdatedApplicationResponse>().ReverseMap();
            CreateMap<Application, DeletedApplicationResponse>().ReverseMap();

            CreateMap<Application, GetListApplicationResponse>().ReverseMap();
            CreateMap<Paginate<Application>, Paginate<GetListApplicationResponse>>().ReverseMap();
        }
    }
}
