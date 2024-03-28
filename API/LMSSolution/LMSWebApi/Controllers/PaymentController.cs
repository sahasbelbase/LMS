using HARS.Application.Model;
using LMS.Application.Services.Payment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMSWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        [HttpGet]
        public IActionResult GetCustomerPayment(string Json) {
            try {
                var payment = _paymentService.GetCustomerPayment(Json);
                return Ok(payment);
            }
            catch(Exception ex) { 
                return BadRequest(ex.Message);
            }
            
            }


        [HttpGet]
        public IActionResult GetPayment(string Json) {
            try
            { var payment = _paymentService.GetPayment(Json);
                return Ok(payment);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
            { 
            }
            }

        [HttpPost]
        public IActionResult PaymentTsk([FromBody] MvJson Json)
        {
            try 
            { 
                var payment = _paymentService.PaymentTsk(Json.Json);
                return Ok(payment);              
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
