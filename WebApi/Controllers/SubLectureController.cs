using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubLectureController : ControllerBase
    {
        ISubLectureService _subLectureService;
        public SubLectureController(ISubLectureService subLectureService)
        {
            _subLectureService = subLectureService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _subLectureService.GetListSubLecture(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSubLectureRequest createSubLectureRequest)
        {
            var result = await _subLectureService.Add(createSubLectureRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateSubLectureRequest updateSubLectureRequest)
        {
            var result = await _subLectureService.Update(updateSubLectureRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteSubLectureRequest deleteSubLectureRequest)
        {

            var result = await _subLectureService.Delete(deleteSubLectureRequest);
            return Ok(result);
        }
    }
}
