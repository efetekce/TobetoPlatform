using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class ApplicationStepMappingProfile:Profile
    {
        public ApplicationStepMappingProfile()
        {
            CreateMap<CreateApplicationStepRequest, ApplicationStep>().ReverseMap();
            CreateMap<UpdateApplicationStepRequest, ApplicationStep>().ReverseMap();
            CreateMap<DeleteApplicationStepRequest, ApplicationStep>().ReverseMap();

            CreateMap<ApplicationStep, CreatedApplicationStepResponse>().ReverseMap();
            CreateMap<ApplicationStep, UpdatedApplicationStepResponse>().ReverseMap();
            CreateMap<ApplicationStep, DeletedApplicationStepResponse>().ReverseMap();

            CreateMap<ApplicationStep, GetListApplicationStepResponse>().ReverseMap();
            CreateMap<Paginate<ApplicationStep>, Paginate<GetListApplicationStepResponse>>().ReverseMap();
        }
    }
}
