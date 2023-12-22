using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountCourseLessonController : ControllerBase
    {
        IAccountCourseLessonService _accountCourseLessonService;
        public AccountCourseLessonController(IAccountCourseLessonService accountCourseLessonService)
        {
            _accountCourseLessonService = accountCourseLessonService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _accountCourseLessonService.GetListAccountCourseLesson(pageRequest);
            return Ok(result);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateAccountCourseLessonRequest createAccountCourseLessonRequest)
        {
            var result = await _accountCourseLessonService.Add(createAccountCourseLessonRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountCourseLessonRequest updateAccountCourseLessonRequest)
        {
            var result = await _accountCourseLessonService.Update(updateAccountCourseLessonRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountCourseLessonRequest deleteAccountCourseLessonRequest)
        {

            var result = await _accountCourseLessonService.Delete(deleteAccountCourseLessonRequest);
            return Ok(result);
        }

    }
}
