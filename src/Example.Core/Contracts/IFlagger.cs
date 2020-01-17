using System.Threading;
using System.Threading.Tasks;
using Example.Core.Models;

namespace Example.Core.Contracts
{
    public interface IFlagger
    {
        Task<Flag> GetAsync(string flagKey, string entityId, CancellationToken cancellationToken);
    }
}