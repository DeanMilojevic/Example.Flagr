using System.Threading;
using System.Threading.Tasks;
using Example.Core.Flagr.Models;
using Refit;

namespace Example.Core.Flagr
{
    internal interface IFlagrClient
    {
        [Post("/api/v1/evaluation")]
        [Headers("ContentType", "application/json")]
        Task<EvaluationResponse> EvaluationAsync([Body] EvaluationRequest request, CancellationToken cancellationToken);
    }
}