using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountTestResultController : ControllerBase
    {
        IAccountTestResultService _accountTestResultService;
        public AccountTestResultController(IAccountTestResultService accountTestResultService)
        {
            _accountTestResultService=accountTestResultService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _accountTestResultService.GetListAccountTestResult(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAccountTestResultRequest createAccountTestResultRequest)
        {
            var result = await _accountTestResultService.Add(createAccountTestResultRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountTestResultRequest updateAccountTestResultRequest)
        {
            var result = await _accountTestResultService.Update(updateAccountTestResultRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountTestResultRequest deleteAccountTestResultRequest)
        {
            var result = await _accountTestResultService.Delete(deleteAccountTestResultRequest);
            return Ok(result);
        }
    }
}
