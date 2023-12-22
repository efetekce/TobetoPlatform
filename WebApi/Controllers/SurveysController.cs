using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveysController : ControllerBase
    {
        ISurveyService _surveyService;
        public SurveysController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _surveyService.GetListSurvey(pageRequest);
            return Ok(result);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateSurveyRequest createSurveyRequest)
        {
            var result = await _surveyService.Add(createSurveyRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateSurveyRequest updateSurveyRequest)
        {
            var result = await _surveyService.Update(updateSurveyRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteSurveyRequest deleteSurveyRequest)
        {
            var result = await _surveyService.Delete(deleteSurveyRequest);
            return Ok(result);
        }
    }
}
