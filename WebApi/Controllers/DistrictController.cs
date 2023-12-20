﻿using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        IDistrictService _districtService;

        public DistrictController(IDistrictService districtService)
        {
            _districtService = districtService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _districtService.GetDistrictListAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateDistrictRequest createDistrictRequest)
        {
            var result = await _districtService.Add(createDistrictRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateDistrictRequest updateDistrictRequest)
        {
            var result = await _districtService.Update(updateDistrictRequest);
            return Ok(result);
        }

        public async Task<IActionResult> Delete([FromBody] DeleteDistrictRequest deleteDistrictRequest)
        {
            var result = await _districtService.Delete(deleteDistrictRequest);
            return Ok(result);
        }
    }
}
