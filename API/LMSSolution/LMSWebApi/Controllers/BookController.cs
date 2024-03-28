using HARS.Application.Model;
using LMS.Application.Services.Book;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMSWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;

        }

        [HttpGet]
        public IActionResult GetBook(string Json)
        {
            try
            {
                var book = _bookService.GetBook(Json);
                return Ok(book);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        public IActionResult GetUserBook(string Json)
        {
            try
            {
                var book = _bookService.GetUserBook(Json);
                return Ok(book);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public IActionResult BookTsk([FromBody] MvJson Json)
        {
            try
            {
                var book = _bookService.BookTsk(Json.Json);
                return Ok(book);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult BookIssue([FromBody] MvJson Json)
        {
            try
            {
                var book = _bookService.BookIssue(Json.Json);
                return Ok(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



}
    }

