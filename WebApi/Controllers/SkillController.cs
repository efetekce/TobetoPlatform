using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        ISkillService _skillService;
        public SkillsController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _skillService.GetListSkillInformation();
            return Ok(result);
        }


        [HttpPost]

        public async Task<IActionResult> Add([FromBody] CreateSkillRequest createSkillRequest)
        {
            var result = await _skillService.Add(createSkillRequest);
            return Ok(result);
        }

        [HttpPut]

        public async Task<IActionResult> Update([FromBody] UpdateSkillsRequest updateSkillRequest)
        {
            var result = await _skillService.Update(updateSkillRequest);
            return Ok(result);
        }

        [HttpDelete]

        public async Task<IActionResult> Delete([FromBody] DeleteSkillsRequest deleteSkillRequest)
        {
            var result = await _skillService.Delete(deleteSkillRequest);
            return Ok(result);
        }
    }
}