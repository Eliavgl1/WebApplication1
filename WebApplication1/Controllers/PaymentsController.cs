using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBase
    {
        [HttpPost]
        public ActionResult<PaymentResult> ProcessPayment([FromBody] PaymentRequest request)
        {
            // Simulate payment processing
            bool isSuccess = new Random().Next(100) < 80; // 80% success rate

            return new PaymentResult
            {
                IsSuccess = isSuccess,
                TransactionId = isSuccess ? Guid.NewGuid().ToString() : null,
                ErrorMessage = isSuccess ? null : "Payment failed due to insufficient funds"
            };
        }
    }
}
