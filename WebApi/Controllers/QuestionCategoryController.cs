using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionCategoryController : ControllerBase
    {
        IQuestionCategoryService _questionCategoryService;

        public QuestionCategoryController(IQuestionCategoryService questionCategoryService)
        {
            _questionCategoryService = questionCategoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _questionCategoryService.GetQuestionCategoryListAsync(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateQuestionCategoryRequest createQuestionCategoryRequest)
        {
            var result = await _questionCategoryService.Add(createQuestionCategoryRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateQuestionCategoryRequest updateQuestionCategoryRequest)
        {
            var result = await _questionCategoryService.Update(updateQuestionCategoryRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteQuestionCategoryRequest deleteQuestionCategoryRequest)
        {

            var result = await _questionCategoryService.Delete(deleteQuestionCategoryRequest);
            return Ok(result);
        }
    }
}
