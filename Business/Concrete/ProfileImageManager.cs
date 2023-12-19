using Business.Abstract;
using Core.Helpers;
using Core.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProfileImageManager : IProfileImageService
    {
        IProfileImageDal _profileImageDal;
        public ProfileImageManager(IProfileImageDal profileImage)
        {
            _profileImageDal = profileImage;
        }
        public Core.Results.IResult Add(IFormFile file, ProfileImage profileImage)
        {
            profileImage.ImagePath = FileHelper.Add(file);
            profileImage.CreatedDate = DateTime.Now;
            _profileImageDal.Add(profileImage);
            return new SuccessResult("Basariyla eklendi");
            
        }

        public Core.Results.IResult Delete(ProfileImage profileImage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ProfileImage> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ProfileImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ProfileImage>> GetImagesByProfileId(int id)
        {
            throw new NotImplementedException();
        }

        public Core.Results.IResult Update(IFormFile file, ProfileImage profileImage)
        {
            throw new NotImplementedException();
        }

        Core.Results.IResult IProfileImageService.Update(IFormFile file, ProfileImage profileImage)
        {
            throw new NotImplementedException();
        }
    }
}
