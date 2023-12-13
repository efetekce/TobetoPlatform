using Business.Abstract;
using Business.Dtos.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        ISkillsService _skillService;

        public SkillsController(ISkillsService skillService)
        {
            _skillService = skillService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _skillService.GetListSkills();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSkillsRequest createSkillsRequest)
        {
            var result = await _skillService.Add(createSkillsRequest);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateSkillsRequest updateSkillsRequest)
        {
            var result = await _skillService.Update(updateSkillsRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteSkillsRequest deleteSkillsRequest)
        {

            var result = await _skillService.Delete(deleteSkillsRequest);
            return Ok(result);
        }
    }
}
