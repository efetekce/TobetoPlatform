using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace WebAPI.Controllers
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

        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _experienceService.GetExperienceListAsync(pageRequest);
            return Ok(result);
        }

        [HttpPost]

        public async Task<IActionResult> Add([FromBody] CreateExperienceRequest createExperienceRequest)
        {
            var result = await _experienceService.Add(createExperienceRequest);
            return Ok(result);
        }

        [HttpPut]

        public async Task<IActionResult> Update([FromBody] UpdateExperienceRequest updateExperienceRequest)
        {
            await _experienceService.Update(updateExperienceRequest);
            return Ok();
        }

        [HttpDelete]

        public async Task<IActionResult> Delete([FromBody] DeleteExperienceRequest deleteExperienceRequest)
        {
            await _experienceService.Delete(deleteExperienceRequest);
            return Ok();
        }
    }
}
