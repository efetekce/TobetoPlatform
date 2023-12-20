using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.Entities.Concrete;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserRegisterMappingProfile :Profile
    {
        public UserRegisterMappingProfile()
        {
            CreateMap<CreateUserRegisterRequest, User>().ReverseMap();
            CreateMap<User,CreatedUserRegisterResponse>().ReverseMap();
        }
    }
}
