using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssessmentController : ControllerBase
    {
        IAssessmentService _assessmentService;

        public AssessmentController(IAssessmentService assessmentService)
        {
            _assessmentService = assessmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _assessmentService.GetAssessmentListAsync(pageRequest);
            return Ok(result);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateAssessmentRequest createAssessmentRequest)
        {
            var result = await _assessmentService.Add(createAssessmentRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAssessmentRequest updateAssessmentRequest)
        {
            var result = await _assessmentService.Update(updateAssessmentRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAssessmentRequest deleteAssessmentRequest)
        {

            var result = await _assessmentService.Delete(deleteAssessmentRequest);
            return Ok(result);
        }
    }
}
