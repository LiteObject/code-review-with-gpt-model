using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        private readonly ILogger<InfoController> _logger;

        public InfoController(ILogger<InfoController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _logger.LogInformation("InfoController instantiated.");
        }

        /// <summary>
        /// Gets a simple message.
        /// This is a sample message to demonstrate the API functionality.
        /// </summary>
        /// <returns>
        /// A string message indicating the API is working.
        /// </returns>
        [HttpGet(Name = "Get")]
        public IActionResult Get()
        {
            var message = "Hello World from InfoController. This is a sample message.";
            _logger.LogInformation(message);
            return Ok(message);
        }

        /// <summary>
        /// Gets a hello message.
        /// This is a sample message to demonstrate the API functionality.
        /// </summary>
        /// <returns>
        /// A string message indicating the API is working.
        /// </returns>
        [HttpGet("hello")]
        public IActionResult Hello()
        {
            var message = "Hello from InfoController!";
            _logger.LogInformation(message);
            return Ok(message);
        }
    }
}
