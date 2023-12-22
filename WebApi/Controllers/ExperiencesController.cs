using Business.Abstract;
using Business.Dtos.Request;
using DataAccess.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperiencesController : ControllerBase
    {
        IExperienceService _experienceService;
        public ExperiencesController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        [HttpGet]
        public async Task<IActionResult>GetList()
        {
            var result = await _experienceService.GetListExperience();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateExperienceRequest createExperienceRequest)
        {
            var result = await _experienceService.Add(createExperienceRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateExperienceRequest updateExperienceRequest)
        {
            var result = await _experienceService.Update(updateExperienceRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteExperienceRequest deleteExperienceRequest)
        {
            var result=await _experienceService.Delete(deleteExperienceRequest);
            return Ok(result);
        }
    }
}
