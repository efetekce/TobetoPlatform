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
    public class AnnouncementMappingProfile : Profile
    {
        public AnnouncementMappingProfile()
        {
            CreateMap<CreateAnnouncementRequest, Announcement>().ReverseMap();
            CreateMap<UpdateAnnouncementRequest, Announcement>().ReverseMap();
            CreateMap<DeleteAnnouncementRequest, Announcement>().ReverseMap();

            CreateMap<Announcement, GetListAnnouncementResponse>().ReverseMap();
            CreateMap<Paginate<Announcement>, Paginate<GetListAnnouncementResponse>>().ReverseMap();
            CreateMap<CreatedAnnouncementResponse, Announcement>().ReverseMap();

            CreateMap<Announcement, UpdatedAnnouncementResponse>().ReverseMap();
            CreateMap<Announcement, DeletedAnnouncementResponse>().ReverseMap();
        }
    }
}
