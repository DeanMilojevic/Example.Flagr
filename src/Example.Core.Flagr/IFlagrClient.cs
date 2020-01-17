using System.Threading;
using System.Threading.Tasks;
using Example.Core.Flagr.Models;
using Refit;

namespace Example.Core.Flagr
{
    internal interface IFlagrClient
    {
        [Post("/evaluation")]
        Task<EvaluationResponse> EvaluationAsync(EvaluationRequest body, CancellationToken cancellationToken);
    }
}