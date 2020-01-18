using System;
using Example.Core.Contracts;
using Example.Core.Flagr.Options;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace Example.Core.Flagr.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddFlaggerClient(this IServiceCollection services, FlagrOptions options)
        {
            services.AddRefitClient<IFlagrClient>()
                    .ConfigureHttpClient(client =>
                    {
                        client.BaseAddress = new Uri(options.Uri);
                    });

            services.AddTransient<IFlagger, Flagger>();

            return services;
        }
    }
}