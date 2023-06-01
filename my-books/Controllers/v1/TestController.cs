using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace my_books.Controllers.v1
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [ApiVersion("1.9")]
    [ApiVersion("3.0")]
    [Route("api/[controller]")]
    //[Route("api/v(version:apiVersion/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        
        [HttpGet("get-test-data"), MapToApiVersion("1.0")]
        public IActionResult Getv1()
        {
            return Ok("This is test controller v1");
        }

        [HttpGet("get-test-data"), MapToApiVersion("2.0")]
        public IActionResult Getv2()
        {
            return Ok("This is test controller v2");
        }

        [HttpGet("get-test-data"), MapToApiVersion("1.9")]
        public IActionResult Getv19()
        {
            return Ok("This is test controller v19");
        }

        [HttpGet("get-test-data"), MapToApiVersion("3.0")]
        public IActionResult Getv3()
        {
            return Ok("This is test controller v3");
        }
    }
}
