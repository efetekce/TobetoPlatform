﻿using AutoMapper;
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
    public class AnnouncementTypeMappingProfile:Profile
    {
        public AnnouncementTypeMappingProfile()
        {
            CreateMap<CreateAnnouncementTypeRequest, AnnouncementType>().ReverseMap();
            CreateMap<UpdateAnnouncementTypeRequest, AnnouncementType>().ReverseMap();
            CreateMap<DeleteAnnouncementTypeRequest, AnnouncementType>().ReverseMap();

            CreateMap<AnnouncementType, GetListAnnouncementTypeResponse>().ReverseMap();
            CreateMap<Paginate<AnnouncementType>, Paginate<GetListAnnouncementTypeResponse>>().ReverseMap();
            
            CreateMap<CreatedAnnouncementTypeResponse, AnnouncementType>().ReverseMap();
            CreateMap<UpdatedAnnouncementTypeResponse, AnnouncementType>().ReverseMap();
            CreateMap<DeletedAnnouncementTypeResponse, AnnouncementType>().ReverseMap();
        }
    }
}
