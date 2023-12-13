using Business.Abstract;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileImageController : ControllerBase
    {
        IProfileImageService _profileImageService;

        public ProfileImageController(IProfileImageService profileImageService)
        {
            _profileImageService = profileImageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _profileImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(/*[FromForm(Name = ("Id"))] */int Id)
        {
            var result = _profileImageService.Get(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] ProfileImage profileImage)
        {

            var result = _profileImageService.Add(file, profileImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int Id)
        {
            var carImage = _profileImageService.Get(Id).Data;
            var result = _profileImageService.Update(file, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = ("Id"))] int Id)
        {
            var profileImage = _profileImageService.Get(Id).Data;
            var result = _profileImageService.Delete(profileImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getimagesbyprofileid")]
        public IActionResult GetImagesByProfileId(int carId)
        {
            var result = _profileImageService.GetImagesByProfileId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
