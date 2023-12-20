﻿using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        //List<OperationClaim> GetClaims(User user);
        //Task<CreatedUserRegisterResponse> AddSync(User user);
        //User GetByMail(string email);
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string? email);
    }
}