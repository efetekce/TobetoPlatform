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
    public class OrganizationMappingProfile : Profile
    {
        public OrganizationMappingProfile()
        {
            CreateMap<CreateOrganizationRequest, Organization>().ReverseMap();
            CreateMap<UpdateOrganizationRequest, Organization>().ReverseMap();
            CreateMap<DeleteOrganizationRequest, Organization>().ReverseMap();

            CreateMap<Organization, CreatedOrganizationResponse>().ReverseMap();
            CreateMap<Organization, UpdatedOrganizationResponse>().ReverseMap();
            CreateMap<Organization, DeletedOrganizationResponse>().ReverseMap();

            CreateMap<Organization, GetListOrganizationResponse>().ReverseMap();
            CreateMap<Paginate<Organization>, Paginate<GetListOrganizationResponse>>().ReverseMap();
        }
    }
}
