using Business.Constants.Messages;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class AuthBusinessRules
    {
        private readonly IUserDal _userDal;
        public AuthBusinessRules(IUserDal userDal)
        {
            _userDal = userDal; 
        }

        public async Task EmailCanNotBeDuplicatedWhenRegistered(string email)
        {
            User? user = await _userDal.GetAsync(u => u.Email == email);
            if (user != null) throw new BusinessException("Mail already exists");

        }

    }
}
