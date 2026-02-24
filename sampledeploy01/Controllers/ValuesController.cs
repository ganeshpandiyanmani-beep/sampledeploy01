using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace sampledeploy01.Controllers
{
    [Route("api")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("/test")]
        public async Task<string> TestTask()
        {
            return await Task.FromResult("Test call");
        }
    }
}
