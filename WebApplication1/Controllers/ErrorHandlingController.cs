using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorHandlingController : ControllerBase
    {
        [HttpGet("division")]
        public IActionResult GetDivisionResult(int numerator, int denominator)
        {
            try
            {
                var result = numerator / denominator; // This will throw DivideByZeroException if denominator is zero
                return Ok("Here's the result: " + result);
                //if (denominator == 0)
                //{
                //    throw new DivideByZeroException("Denominator cannot be zero.");
                //}
                //int result = numerator / denominator;
                //return Ok(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: Division by zero is not allowed. {ex.Message}");
                return BadRequest("Cannot divide by zero. Please provide a non-zero denominator.");
                //return BadRequest(new { error = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { error = "An unexpected error occurred.", details = ex.Message });
            }
        }
    }
}
