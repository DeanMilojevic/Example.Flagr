using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Example.Flagr.Tests
{
    public class FlagrTests
    {
        [Fact]
        public async Task Run()
        {
            using var client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5000")
            };

            var response = await client.GetAsync("/api/example/test/test");

            Assert.NotNull(response.Content);
        }
    }
}
