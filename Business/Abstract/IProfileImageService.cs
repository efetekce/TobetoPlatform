﻿using Core.Results;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProfileImageService
    {
        Core.Results.IResult Add(IFormFile file, ProfileImage profileImage);
        Core.Results.IResult Delete(ProfileImage profileImage);
        Core.Results.IResult Update(IFormFile file, ProfileImage profileImage);
        IDataResult<ProfileImage> Get(int id);
        IDataResult<List<ProfileImage>> GetAll();
        IDataResult<List<ProfileImage>> GetImagesByProfileId(int id);

    }
}
