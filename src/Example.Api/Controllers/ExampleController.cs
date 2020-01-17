using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Examples.Controllers
{
    [ApiController]
    [Route("api/example")]
    public class ExampleController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> PostAsync(CancellationToken cancellationToken) => Ok();
    }
}