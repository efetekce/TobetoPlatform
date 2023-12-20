﻿using Business.Abstract;
using Business.Dtos.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationStepsController : ControllerBase
    {
        IApplicationStepService _applicationStepService;
        public ApplicationStepsController(IApplicationStepService applicationStepService)
        {
            _applicationStepService = applicationStepService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _applicationStepService.GetListApplicationStep();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateApplicationStepRequest createApplicationStepRequest)
        {
            var result = await _applicationStepService.Add(createApplicationStepRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateApplicationStepRequest updateApplicationStepRequest)
        {
            var result = await _applicationStepService.Update(updateApplicationStepRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteApplicationStepRequest deleteApplicationStepRequest)
        {
            var result = await _applicationStepService.Delete(deleteApplicationStepRequest);
            return Ok(result);
        }
    }
}
