using Business.Abstract;
using Business.Dtos.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountCertificateController : ControllerBase
    {
        IAccountCertificateService _accountCertificateService;
        public AccountCertificateController(IAccountCertificateService certificate)
        {
            _accountCertificateService = certificate;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _accountCertificateService.GetListCertificate(pageRequest);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAccountCertificateRequest createCertitificateRequest)
        {
            var result = await _accountCertificateService.Add(createCertitificateRequest);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateAccountCertificateRequest updateCertitificateRequest)
        {
            var result = await _accountCertificateService.Update(updateCertitificateRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteAccountCertificateRequest deleteCertitificateRequest)
        {

            var result = await _accountCertificateService.Delete(deleteCertitificateRequest);
            return Ok(result);
        }
    }
}
