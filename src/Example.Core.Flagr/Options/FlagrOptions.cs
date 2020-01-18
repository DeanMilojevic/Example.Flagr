using System.ComponentModel.DataAnnotations;

namespace Example.Core.Flagr.Options
{
    public sealed class FlagrOptions
    {
        [Required]
        public string Uri { get; set; }
    }
}
