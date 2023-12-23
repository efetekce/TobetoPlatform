using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
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

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _personalInformationService.GetListPersonalInformation(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreatePersonalInformationRequest createPersonalInformationRequest)
        {
            var result = await _personalInformationService.Add(createPersonalInformationRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdatePersonalInformationRequest updatePersonalInformationRequest)
        {
            var result = await _personalInformationService.Update(updatePersonalInformationRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeletePersonalInformationRequest deletePersonalInformationRequest)
        {

            var result = await _personalInformationService.Delete(deletePersonalInformationRequest);
            return Ok(result);
        }
    }
}
