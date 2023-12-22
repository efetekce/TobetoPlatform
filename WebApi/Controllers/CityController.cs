﻿using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _cityService.GetCityListAsync(pageRequest);
            return Ok(result);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateCityRequest createCityRequest)
        {
            var result = await _cityService.Add(createCityRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCityRequest updateCityRequest)
        {
            var result = await _cityService.Update(updateCityRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCityRequest deleteCityRequest)
        {

            var result = await _cityService.Delete(deleteCityRequest);
            return Ok(result);
        }
    }
}
