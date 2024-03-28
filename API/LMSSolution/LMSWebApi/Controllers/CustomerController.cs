using HARS.Application.Model;
using LMS.Application.Service.Customer;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Application.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CustomerController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomerController(ICustomerService custommerService)
        {
            _customerService = custommerService;
            
        }

        [HttpGet]
        public IActionResult GetCustomer(string Json)
        {
            try
            {
                var customer = _customerService.GetCustomer(Json);
                return Ok(customer);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        
        }


        




    }
}
