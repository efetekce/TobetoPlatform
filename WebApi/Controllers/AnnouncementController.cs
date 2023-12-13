﻿using Business.Abstract;
using Business.Dtos.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _announcementService.GetListAnnouncement();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAnnouncementRequest createAnnouncementRequest)
        {
            var result = await _announcementService.Add(createAnnouncementRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAnnouncementRequest updateAnnouncementRequest)
        {
            var result = await _announcementService.Update(updateAnnouncementRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAnnouncementRequest deleteAnnouncementRequest)
        {

            var result = await _announcementService.Delete(deleteAnnouncementRequest);
            return Ok(result);
        }
    }
}
