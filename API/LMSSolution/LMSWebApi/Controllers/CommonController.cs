using HARS.Application.Model;
using LMS.Application.Services.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMSWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        ICommonService _commonService;

        public CommonController(ICommonService commonService)
        {
            _commonService = commonService;
        }
        [HttpGet]
        public IActionResult GetNavigation(string Json)
        {
            try
            {
                var common = _commonService.GetNavigation(Json);
                return Ok(common);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }



        }
        [HttpGet]
        public IActionResult GetCustomerNavigation(string Json)
        {
            try
            {
                var common = _commonService.GetCustomerNavigation(Json);
                return Ok(common);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }



        }
        [HttpGet]
        public IActionResult GetUserDashboard(string Json)
        {
            try
            {
                var common = _commonService.GetUserDashboard(Json);
                return Ok(common);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult GetDashboard(string Json)
        {
            try
            {
                var common = _commonService.GetDashboard(Json);
                return Ok(common);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        public IActionResult GetUser(string Json)
        {
            try
            {
                var common = _commonService.GetUser(Json);
                return Ok(common);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetUserPerson(string Json)
        {
            try
            {
                var common = _commonService.GetUserPerson(Json);
                return Ok(common);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult UserTsk([FromBody] MvJson json)
        {
            try
            {
                var userPerson = _commonService.UserTsk(json.Json);
                return Ok(userPerson);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult UserPersonTsk([FromBody] MvJson json)
        {
            try
            {
                var userPerson = _commonService.UserPersonTsk(json.Json);
                return Ok(userPerson);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
