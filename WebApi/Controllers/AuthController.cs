using Business.Abstract;
using Business.Dtos.Request;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AuthController : Controller
    {
    //    private IAuthService _authService;
    //    private IUserService _userService;

    //    public AuthController(IAuthService authService, IUserService userService)
    //    {
    //        _authService = authService;
    //        _userService = userService;
    //    }

    // [HttpPost("login")]
    // public  Task<ActionResult> Login(UserForLoginDto userForLoginDto)
    //{
    //var userToLogin =  _authService.Login(userForLoginDto);
    //if (-!userToLogin.Result)
    //{
    //    return BadRequest(userToLogin.Message);
    //}

    //var result =await _authService.CreateAccessToken(userToLogin);
    //if (result.)
    //{
    //    return Ok(result);
    //}

    // return BadRequest(result);
    // }

    //  [HttpPost("register")]
    //public ActionResult Register(UserForRegisterDto userForRegisterDto)
    //{
    //var userExists = _authService.UserExists(userForRegisterDto.Email);
    //if (!userExists.Success)
    //{
    //    return BadRequest(userExists.Message);
    //}

    //var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
    //var result = _authService.CreateAccessToken(registerResult.Data);
    //if (result.Success)
    //{
    //    return Ok(result.Data);
    //}
    //return BadRequest(result.Message);
    //}
    //}

    }
}


