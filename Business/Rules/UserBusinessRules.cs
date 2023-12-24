using Business.Constants.Messages;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class UserBusinessRules
    {
        private readonly IUserDal _userDal;
        public UserBusinessRules(IUserDal userDal)
        {
            _userDal = userDal; 
        }

        public async Task SameEmail(string email)
        {
            var result = await _userDal.GetListAsync(c => c.Email == email);

            if (result != null)
            {
                throw new BusinessException("aynı email sistemde mevcut");
            }

        }
    }
}
