using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementTypeController : ControllerBase
    {
        IAnnouncementTypeService _announcementTypeService;

        public AnnouncementTypeController(IAnnouncementTypeService announcementTypeService)
        {
            _announcementTypeService = announcementTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _announcementTypeService.GetListAnnouncementType(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAnnouncementTypeRequest createAnnouncementTypeRequest)
        {
            var result = await _announcementTypeService.Add(createAnnouncementTypeRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAnnouncementTypeRequest updateAnnouncementTypeRequest)
        {
            var result = await _announcementTypeService.Update(updateAnnouncementTypeRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAnnouncementTypeRequest deleteAnnouncementTypeRequest)
        {
            var result = await _announcementTypeService.Delete(deleteAnnouncementTypeRequest);
            return Ok(result);
        }
    }
}
