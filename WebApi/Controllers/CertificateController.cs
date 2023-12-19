using Business.Abstract;
using Business.Dtos.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateController : ControllerBase
    {
        ICertificateService _certificateService;
        public CertificateController(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }     

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _certificateService.GetListCertificate();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCertitificateRequest createCertitificateRequest)
        {
            var result = await _certificateService.Add(createCertitificateRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCertitificateRequest updateCertitificateRequest)
        {
            var result = await _certificateService.Update(updateCertitificateRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCertitificateRequest deleteCertitificateRequest)
        {

            var result = await _certificateService.Delete(deleteCertitificateRequest);
            return Ok(result);
        }
    }
}
