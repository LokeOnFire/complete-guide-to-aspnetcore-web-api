using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using my_books.Model;
using my_books.Model.Repository;
using System.Reflection.Metadata.Ecma335;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookRepository _service;
        private ILogger<BookController> _logger;

        public BookController(IBookRepository service, ILogger<BookController> logger = null)
        {
            _service = service;
            _logger = logger;
        }

        [HttpPost("add-book")]
        public IActionResult Add([FromBody] Book book) {

            _service.Add(book);

            return Ok();
        }

        [HttpGet("Get-all-books/{pageno}")]
        public IActionResult GetAll(int pageno) { 

            return Ok(_service.GetAll(pageno)); 
        }

        [HttpGet("get-book-by-id/{id}")]
        public IActionResult Get(int id)
        {
            _logger.LogInformation("Hellow lokesh");
            var _result = _service.Get(id);

            //return _restult !=null ? Ok(_restult) : NotFound();
            return Ok(_result);

            //return Ok(_service.Get(id));
        }
    }
}
