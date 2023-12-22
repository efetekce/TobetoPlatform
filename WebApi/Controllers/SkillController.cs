﻿using Business.Abstract;
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
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _skillService.GetListSkillInformation(pageRequest);
            return Ok(result);
        }


        [HttpPost("Add")]

        public async Task<IActionResult> Add([FromBody] CreateSkillRequest createSkillRequest)
        {
            var result = await _skillService.Add(createSkillRequest);
            return Ok(result);
        }

        [HttpPost("Update")]

        public async Task<IActionResult> Update([FromBody] UpdateSkillsRequest updateSkillRequest)
        {
            var result = await _skillService.Update(updateSkillRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]

        public async Task<IActionResult> Delete([FromBody] DeleteSkillsRequest deleteSkillRequest)
        {
            var result = await _skillService.Delete(deleteSkillRequest);
            return Ok(result);
        }
    }
}