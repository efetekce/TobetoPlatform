using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountPasswordsController : ControllerBase
    {
        IAccountPasswordService _accountPasswordService;
        public AccountPasswordsController(IAccountPasswordService accountPasswordService)
        {
            _accountPasswordService = accountPasswordService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _accountPasswordService.GetListAccountPassword(pageRequest);
            return Ok(result);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateAccountPasswordRequest createAccountPasswordRequest)
        {
            var result = await _accountPasswordService.Add(createAccountPasswordRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountPasswordRequest updateAccountPasswordRequest)
        {
            var result = await _accountPasswordService.Update(updateAccountPasswordRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountPasswordRequest deleteAccountPasswordRequest)
        {
            var result = await _accountPasswordService.Delete(deleteAccountPasswordRequest);
            return Ok(result);
        }
    }
}
