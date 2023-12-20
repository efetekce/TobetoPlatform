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
    public class AddressMappingProfile : Profile
    {
        public AddressMappingProfile()
        {
            CreateMap<CreateAddressRequest, Address>().ReverseMap();
            CreateMap<UpdateAddressRequest, Address>().ReverseMap();
            CreateMap<DeleteAddressRequest, Address>().ReverseMap();

            CreateMap<Address, GetListAddressResponse>().ReverseMap();
            CreateMap<Paginate<Address>, Paginate<GetListAddressResponse>>().ReverseMap();
            CreateMap<CreatedAddressResponse, Address>().ReverseMap();

            CreateMap<Address, UpdatedAddressResponse>().ReverseMap();
            CreateMap<Address, DeletedAddressResponse>().ReverseMap();
        }
    }
}
