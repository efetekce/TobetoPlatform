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
    public class MembershipStatusMappingProfile:Profile
    {
        public MembershipStatusMappingProfile()
        {
            CreateMap<CreateMembershipStatusRequest, MembershipStatus>().ReverseMap();
            CreateMap<UpdateMembershipStatusRequest, MembershipStatus>().ReverseMap();
            CreateMap<DeleteMembershipStatusRequest, MembershipStatus>().ReverseMap();

            CreateMap<MembershipStatus, GetListMembershipStatusResponse>().ReverseMap();
            CreateMap<Paginate<MembershipStatus>, Paginate<GetListMembershipStatusResponse>>().ReverseMap();

            CreateMap<MembershipStatus, CreatedMembershipStatusResponse>().ReverseMap();
            CreateMap<MembershipStatus, UpdatedMembershipStatusResponse>().ReverseMap();
            CreateMap<MembershipStatus, DeletedMembershipStatusResponse>().ReverseMap();
        }
    }
}
