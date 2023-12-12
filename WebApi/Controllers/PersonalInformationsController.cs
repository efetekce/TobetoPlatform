using Business.Abstract;
using Business.Dtos.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalInformationsController : ControllerBase
    {
        IPersonalInformationService _personalInformationService;
        public PersonalInformationsController(IPersonalInformationService personalInformationService)
        {
            _personalInformationService = personalInformationService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreatePersonalInformationRequest createPersonalInformationRequest)
        {
            var result = await _personalInformationService.Add(createPersonalInformationRequest);
            return Ok(result);
        }
    }
}
