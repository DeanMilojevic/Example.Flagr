using System.Threading;
using System.Threading.Tasks;
using Example.Core.Contracts;
using Example.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examples.Controllers
{
    [ApiController]
    [Route("api/example")]
    public class ExampleController : ControllerBase
    {
        private readonly IFlagger _flagger;

        public ExampleController(IFlagger flagger)
        {
            _flagger = flagger;
        }

        [HttpGet("{key}/{id}")]
        public async Task<ActionResult<Flag>> GetAsync(string key, string id, CancellationToken cancellationToken)
        {
            var flag = await _flagger.GetAsync(key, id, cancellationToken);

            return new JsonResult(flag.EnitityId);
        }
    }
}