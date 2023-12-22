using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationStepsController : ControllerBase
    {
        IApplicationStatusService _applicationStepService;
        public ApplicationStepsController(IApplicationStatusService applicationStepService)
        {
            _applicationStepService = applicationStepService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _applicationStepService.GetListApplicationStatus(pageRequest);
            return Ok(result);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateApplicationStatusRequest createApplicationStepRequest)
        {
            var result = await _applicationStepService.Add(createApplicationStepRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateApplicationStatusRequest updateApplicationStepRequest)
        {
            var result = await _applicationStepService.Update(updateApplicationStepRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteApplicationStatusRequest deleteApplicationStepRequest)
        {
            var result = await _applicationStepService.Delete(deleteApplicationStepRequest);
            return Ok(result);
        }
    }
}
