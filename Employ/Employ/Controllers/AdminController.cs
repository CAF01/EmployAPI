using Microsoft.AspNetCore.Mvc;

namespace Employ.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAlgo() { 
            return new OkObjectResult(new List<int> { 1, 2, 3, 4, 5 });
        }
    }
}
