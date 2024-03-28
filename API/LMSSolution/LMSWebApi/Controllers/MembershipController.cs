using LMS.Application.Services.Membership;
using Microsoft.AspNetCore.Mvc;

namespace LMSWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MembershipController : ControllerBase
    {
        IMemebershipService _membershipService;
        public MembershipController(IMemebershipService membershipService)
        {
            _membershipService = membershipService;
        }
        [HttpGet]
        public IActionResult GetMembership(string Json)
        {
            try
            {
                var membership = _membershipService.GetMembership(Json);
                return Ok(membership);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


    }
}

