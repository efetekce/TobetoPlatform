using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformCatalogController : ControllerBase
    {
        IPlatformCatalogService _platformCatalogService;
        public PlatformCatalogController(IPlatformCatalogService platformCatalogService)
        {
            _platformCatalogService = platformCatalogService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _platformCatalogService.GetListPlatformCatalog();
            return Ok(result);
        }
    }
}
