using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class ApplicationStatusMappingProfile:Profile
    {
        public ApplicationStatusMappingProfile()
        {
            CreateMap<CreateApplicationStatusRequest, ApplicationStatus>().ReverseMap();
            CreateMap<UpdateApplicationStatusRequest, ApplicationStatus>().ReverseMap();
            CreateMap<DeleteApplicationStatusRequest, ApplicationStatus>().ReverseMap();

            CreateMap<ApplicationStatus, CreatedApplicationStatusResponse>().ReverseMap();
            CreateMap<ApplicationStatus, UpdatedApplicationStatusResponse>().ReverseMap();
            CreateMap<ApplicationStatus, DeletedApplicationStatusResponse>().ReverseMap();

            CreateMap<ApplicationStatus, GetListApplicationStatusResponse>().ReverseMap();
            CreateMap<Paginate<ApplicationStatus>, Paginate<GetListApplicationStatusResponse>>().ReverseMap();
        }
    }
}
