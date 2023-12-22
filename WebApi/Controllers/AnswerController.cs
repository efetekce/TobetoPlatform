using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        IAnswerService _answerService;

        public AnswerController(IAnswerService answerService)
        {
            _answerService = answerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _answerService.GetAnswerListAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAnswerRequest createAnswerRequest)
        {
            var result = await _answerService.Add(createAnswerRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAnswerRequest updateAnswerRequest)
        {
            var result = await _answerService.Update(updateAnswerRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAnswerRequest deleteAnswerRequest)
        {

            var result = await _answerService.Delete(deleteAnswerRequest);
            return Ok(result);
        }
    }
}
