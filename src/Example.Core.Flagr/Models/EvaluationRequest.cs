using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Example.Core.Flagr.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    internal struct EvaluationRequest
    {
        public string FlagKey { get; set; }
        public string EntityId { get; set; }
    }
}