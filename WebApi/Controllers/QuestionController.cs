﻿using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _questionService.GetQuestionListAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateQuestionRequest createQuestionRequest)
        {
            var result = await _questionService.Add(createQuestionRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateQuestionRequest updateQuestionRequest)
        {
            var result = await _questionService.Update(updateQuestionRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteQuestionRequest deleteQuestionRequest)
        {

            var result = await _questionService.Delete(deleteQuestionRequest);
            return Ok(result);
        }
    }
}
