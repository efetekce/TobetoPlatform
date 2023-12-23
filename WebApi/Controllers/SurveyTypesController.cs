using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyTypesController : ControllerBase
    {
        ISurveyTypeService _surveyTypeService;
        public SurveyTypesController(ISurveyTypeService surveyTypeService)
        {
            _surveyTypeService = surveyTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _surveyTypeService.GetListSurveyType(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSurveyTypeRequest createSurveyTypeRequest)
        {
            var result = await _surveyTypeService.Add(createSurveyTypeRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateSurveyTypeRequest updateSurveyTypeRequest)
        {
            var result = await _surveyTypeService.Update(updateSurveyTypeRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteSurveyTypeRequest deleteSurveyTypeRequest)
        {
            var result = await _surveyTypeService.Delete(deleteSurveyTypeRequest);
            return Ok(result);
        }
    }
}
