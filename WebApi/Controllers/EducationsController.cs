using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationsController : ControllerBase
    {
        IEducationService _educationService;
        public EducationsController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        [HttpGet]

        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _educationService.GetEducationListAsync(pageRequest);
            return Ok(result);
        }

        [HttpPost]

        public async Task<IActionResult> Add([FromBody] CreateEducationRequest createEducationRequest)
        {
            var result = await _educationService.Add(createEducationRequest);
            return Ok(result);
        }

        [HttpPut]

        public async Task<IActionResult> Update([FromBody] UpdateEducationRequest updateEducationRequest)
        {
            var result=await _educationService.Update(updateEducationRequest);
            return Ok(result);
        }

        [HttpDelete]

        public async Task<IActionResult> Delete([FromBody] DeleteEducationRequest deleteEducationRequest)
        {
            var result=await _educationService.Delete(deleteEducationRequest);
            return Ok(result);
        }
    }
}
