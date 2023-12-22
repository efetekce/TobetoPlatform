using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionStatusController : ControllerBase
    {
        ISessionStatusService _sessionStatusService;
        public SessionStatusController(ISessionStatusService sessionStatusService)
        {
            _sessionStatusService = sessionStatusService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _sessionStatusService.GetListSessionStatus(pageRequest);
            return Ok(result);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateSessionStatusRequest createSessionStatusRequest)
        {
            var result = await _sessionStatusService.Add(createSessionStatusRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateSessionStatusRequest updateSessionStatusRequest)
        {
            var result = await _sessionStatusService.Update(updateSessionStatusRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteSessionStatusRequest deleteSessionStatusRequest)
        {
            var result=await _sessionStatusService.Delete(deleteSessionStatusRequest);
            return Ok(result);
        }
    }
}
