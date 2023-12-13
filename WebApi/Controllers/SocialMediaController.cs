using Business.Abstract;
using Business.Dtos.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _socialMediaService.GetListSocialMedias();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSocialMediaRequest createSocialMediaRequest)
        {
            var result = await _socialMediaService.Add(createSocialMediaRequest);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateSocialMediaRequest updateSocialMediaRequest)
        {
            var result = await _socialMediaService.Update(updateSocialMediaRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteSocialMediaRequest deleteSocialMediaRequest)
        {

            var result = await _socialMediaService.Delete(deleteSocialMediaRequest);
            return Ok(result);
        }
    }
}
