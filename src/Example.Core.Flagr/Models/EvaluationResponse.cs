namespace Example.Core.Flagr.Models
{
    internal class EvaluationResponse
    {
        public int FlagId { get; set; }
        public string FlagKey { get; set; }
        public dynamic EvalContext { get; set; }
    }
}