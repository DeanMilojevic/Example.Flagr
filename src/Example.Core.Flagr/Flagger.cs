using System.Threading;
using System.Threading.Tasks;
using Example.Core.Contracts;
using Example.Core.Flagr.Models;
using Example.Core.Models;

namespace Example.Core.Flagr
{
    internal sealed class Flagger : IFlagger
    {
        private readonly IFlagrClient _flagrClient;

        public Flagger(IFlagrClient flagrClient)
        {
            _flagrClient = flagrClient;
        }

        public async Task<Flag> GetAsync(string flagKey, string entityId, CancellationToken cancellationToken)
        {
            var response = await _flagrClient.EvaluationAsync(new EvaluationRequest { FlagKey = flagKey, EntityId = entityId }, cancellationToken);

            return new Flag
            {
                Key = response.FlagKey,
                Context = response.EvalContext
            };
        }
    }
}
