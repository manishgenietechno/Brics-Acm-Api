using BRICS_Acm_Api.Services.Interface;
using DataService.DBModels;
using Microsoft.AspNetCore.Mvc;

namespace BRICS_Acm_Api.Controllers
{
    [Route("api/")]
    [ApiController]
    public class HDFCController : ControllerBase
    {
        private readonly BricsrecosystemContext _dbcontext;
        private IServiceProvider _serviceProvider;

        public HDFCController(BricsrecosystemContext dbcontext, IServiceProvider serviceProvider)
        {
            _dbcontext = dbcontext;
            _serviceProvider = serviceProvider;

        }
        [HttpGet("Testing")]
        public string Testing()
        {
            return "This is Testing Api";
        }

        [HttpPost("external/coreAlert")]
        public async Task<IActionResult> CoreAlert()
        {
            try
            {
                var reader = new StreamReader(Request.Body);
                var request = await reader.ReadToEndAsync();
                if (!string.IsNullOrEmpty(request))
                {
                    var _hdfcService = _serviceProvider.GetRequiredService<IhdfcInterface>();
                    return Ok(await _hdfcService.IcoreNotification(request));
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }
    }
}
