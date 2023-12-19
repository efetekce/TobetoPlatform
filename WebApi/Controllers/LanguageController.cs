using Business.Abstract;
using Business.Dtos.Request;
using DataAccess.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        ILanguageService _languageService;

        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _languageService.GetListLanguage();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateLanguageRequest  createLanguageRequest)
        {
            var result = await _languageService.Add(createLanguageRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateLanguageRequest updateLanguageRequest )
        {
            var result = await _languageService.Update(updateLanguageRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteLanguageRequest deletedLanguageRequest)
        {

            var result = await _languageService.Delete(deletedLanguageRequest);
            return Ok(result);
        }
    }
}
