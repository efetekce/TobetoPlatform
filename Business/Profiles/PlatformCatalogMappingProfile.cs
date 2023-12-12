using AutoMapper;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class PlatformCatalogMappingProfile : Profile
    {
        public PlatformCatalogMappingProfile()
        {

            CreateMap<PlatformCatalog, GetListPlatformCatalogResponse>().ReverseMap();
            CreateMap<Paginate<PlatformCatalog>, Paginate<GetListPlatformCatalogResponse>>().ReverseMap();

        }
    }

}
