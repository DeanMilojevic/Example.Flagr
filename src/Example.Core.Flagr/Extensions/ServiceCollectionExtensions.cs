using System;
using Example.Core.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace Example.Core.Flagr.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddFlaggerrClient(this IServiceCollection services)
        {
            services.AddRefitClient<IFlagrClient>()
                    .ConfigureHttpClient(c =>
                    {
                        c.BaseAddress = new Uri("http://flagr");
                        c.DefaultRequestHeaders.Add("ContentType", "application/json");
                    });

            services.AddTransient<IFlagger, Flagger>();

            return services;
        }
    }
}