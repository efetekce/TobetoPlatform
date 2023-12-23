using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseDetailController : ControllerBase
    {
        ICourseDetailService _courseDetailService;
        public CourseDetailController(ICourseDetailService courseDetailService)
        {
            _courseDetailService = courseDetailService;
        }



        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _courseDetailService.GetListCourseDetail(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCourseDetailRequest createCourseDetailRequest)
        {
            var result = await _courseDetailService.Add(createCourseDetailRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCourseDetailRequest updateCourseDetailRequest)
        {
            var result = await _courseDetailService.Update(updateCourseDetailRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCourseDetailRequest deleteCourseDetailRequest)
        {

            var result = await _courseDetailService.Delete(deleteCourseDetailRequest);
            return Ok(result);
        }

    }
}
