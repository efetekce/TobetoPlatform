using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;
using Core.Results;
using Core.Security.Hashing;
using Core.Security.JWT;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        AuthBusinessRules _authBusinessRules;
        ITokenHelper _tokenHelper;
        IMapper _mapper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper, AuthBusinessRules authBusinessRules,IMapper mapper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _authBusinessRules = authBusinessRules;
            _mapper = mapper;
        }

        public async Task<AccessToken> CreateAccessToken(User user)
        {
            //IPaginate<UserOperationClaim> userOperationClaims =
            //   await _userService.GetListAsync(u => u.UserId == user.Id,
            //   include: u => u.Include(u => u.OperationClaim));
            ////GetListAsync=>> ıuserserviceye ekle

            //ICollection<OperationClaim> operationClaims =
            //    userOperationClaims.Items.Select(u => new OperationClaim
            //    { Id = u.OperationClaim.Id, Name = u.OperationClaim.Name }).ToList();

            //AccessToken accessToken = _tokenHelper.CreateToken(user, operationClaims);
            //return accessToken;
            throw new NotImplementedException();

        }

        public async Task<User> Login(UserForLoginDto userForLoginDto)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            throw new NotImplementedException();
        }

        public IResult UserExists(string email)
        {
            throw new NotImplementedException();
        }
    }
}
