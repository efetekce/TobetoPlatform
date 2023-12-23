using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipStatusController : ControllerBase
    {
        IMembershipStatusService _membershipStatusService;
        public MembershipStatusController(IMembershipStatusService membershipStatusService)
        {
            _membershipStatusService = membershipStatusService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _membershipStatusService.GetListMembershipStatus(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateMembershipStatusRequest createMembershipStatusRequest)
        {
            var result = await _membershipStatusService.Add(createMembershipStatusRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateMembershipStatusRequest updateMembershipStatusRequest)
        {
            var result = await _membershipStatusService.Update(updateMembershipStatusRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteMembershipStatusRequest deleteMembershipStatusRequest) 
        {
            var result = await _membershipStatusService.Delete(deleteMembershipStatusRequest);
            return Ok(result);
        }
    }
}
