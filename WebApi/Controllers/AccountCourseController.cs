using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountCourseController : ControllerBase
    {
        IAccountCourseService _accountCourseService;
        public AccountCourseController(IAccountCourseService accountCourseService)
        {
            _accountCourseService = accountCourseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _accountCourseService.GetListAccountCourse(pageRequest);
            return Ok(result);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateAccountCourseRequest createAccountCourseRequest)
        {
            var result = await _accountCourseService.Add(createAccountCourseRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountCourseRequest updateAccountCourseRequest)
        {
            var result = await _accountCourseService.Update(updateAccountCourseRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountCourseRequest deleteAccountCourseRequest)
        {

            var result = await _accountCourseService.Delete(deleteAccountCourseRequest);
            return Ok(result);
        }

    }
}
