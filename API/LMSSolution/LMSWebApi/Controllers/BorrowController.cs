using HARS.Application.Model;
using LMS.Application.Services.Borrow;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMSWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BorrowController : ControllerBase
    {
        IBorrowService _borrowService;

        public BorrowController(IBorrowService borrowService)
        {
            _borrowService = borrowService;
        }

        [HttpGet]
        public IActionResult GetBorrow(string Json)
        {
            try
            {
                var borrow = _borrowService.GetBorrow(Json);
                return Ok(borrow);
            }
            catch (Exception ex)
            { 
                return BadRequest(ex.Message);
            }
                       
        }

        [HttpPost]
        public IActionResult BookReturnTsk([FromBody] MvJson Json)
        {
            try
            {
                var borrow = _borrowService.BookReturnTsk(Json.Json);
                return Ok(borrow);
            }
            catch  (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
