using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
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
        private ITokenHelper _tokenHelper;
        private IMapper _mapper;

        public AuthManager(IUserService userService,ITokenHelper tokenHelper,IMapper mapper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _mapper = mapper;
        }

        //public async Task<CreatedUserRegisterResponse> Register(CreateUserRegisterRequest createUserRequest, string password)
        //{
        //    byte[] passwordHash, passwordSalt;
        //    HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
        //    User user = _mapper.Map<User>(createUserRequest);
        //    var createdUser = await _userService.AddSync(user);
        //    CreatedUserRegisterResponse result =_mapper.Map<CreatedUserRegisterResponse>(createdUser);   
        //    return result;

        //}


        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserForRegisterDto, User>()
                    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                    .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                    .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                    .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => passwordHash))
                    .ForMember(dest => dest.PasswordSalt, opt => opt.MapFrom(src => passwordSalt))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => true));
            });

            IMapper mapper = config.CreateMapper();
            var user = mapper.Map<User>(userForRegisterDto);

            _userService.Add(user);
            return new SuccessDataResult<User>(user, "kayıt olundu");
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            //var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            //if (userToCheck==null)
            //{
            //    return new ErrorDataResult<User>("kullanıcı bulunamadı");
            //}

            //if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            //{
            //    return new ErrorDataResult<User>("parola hatası");
            //}

            return new SuccessDataResult<User>("basarılı giris");
        }

        //public IResult UserExists(string email)
        //{
        //    if (_userService.GetByMail(email) != null)
        //    {
        //        return new ErrorResult("kullanıcı mevcut");
        //    }
        //    return new SuccessResult();
        //}

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "access token olustu");
        }
    }
}
