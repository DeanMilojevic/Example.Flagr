using System.Threading;
using System.Threading.Tasks;
using Example.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Examples.Controllers
{
    [ApiController]
    [Route("api/example")]
    public class ExampleController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IFlagger _flagger;

        public ExampleController(ILogger<ExampleController> logger, IFlagger flagger)
        {
            _logger = logger;
            _flagger = flagger;
        }

        [HttpGet]
        public async Task<IActionResult> PostAsync(CancellationToken cancellationToken)
        {
            var flag = await _flagger.GetAsync("test", "test", cancellationToken);

            _logger.LogInformation($"{flag.Key}: {flag.Context}");

            return Ok();
        }
    }
}