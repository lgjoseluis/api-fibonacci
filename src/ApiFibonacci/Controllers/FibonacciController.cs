using Application.Fibonacci;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFibonacci.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        private readonly ILogger<FibonacciController> _logger;

        private readonly IApplicationFibonacci _fibonacci;

        public FibonacciController(ILogger<FibonacciController> logger, IApplicationFibonacci fibonacci)
        {
            _logger = logger;
            _fibonacci = fibonacci;
        }



        [HttpGet]
        public long SerieFibonacci(int n)
        {
            return _fibonacci.SerieFibonacci(n);
        }
    }
}
