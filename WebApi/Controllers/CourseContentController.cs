using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseContentController : ControllerBase
    {
        ICourseContentService _courseContentService;
        public CourseContentController(ICourseContentService courseContentService)
        {
            _courseContentService = courseContentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _courseContentService.GetListCourseContent(pageRequest);
            return Ok(result);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateCourseContentRequest createCourseContentRequest)
        {
            var result = await _courseContentService.Add(createCourseContentRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCourseContentRequest updateCourseContentRequest)
        {
            var result = await _courseContentService.Update(updateCourseContentRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCourseContentRequest deleteCourseContentRequest)
        {

            var result = await _courseContentService.Delete(deleteCourseContentRequest);
            return Ok(result);
        }

    }
}
