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
    public class SessionStatusMappingProfile:Profile
    {
        public SessionStatusMappingProfile()
        {
            CreateMap<CreateSessionStatusRequest, SessionStatus>().ReverseMap();
            CreateMap<UpdateSessionStatusRequest, SessionStatus>().ReverseMap();
            CreateMap<DeleteSessionStatusRequest, SessionStatus>().ReverseMap();

            CreateMap<SessionStatus, CreatedSessionStatusResponse>().ReverseMap();
            CreateMap<SessionStatus,UpdatedSessionStatusResponse>().ReverseMap();
            CreateMap<SessionStatus, DeletedSessionStatusResponse>().ReverseMap();

            CreateMap<SessionStatus, GetListSessionStatusResponse>().ReverseMap();
            CreateMap<Paginate<SessionStatus>, Paginate<GetListSessionStatusResponse>>().ReverseMap();
        }
    }
}
