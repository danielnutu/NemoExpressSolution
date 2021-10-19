using Microsoft.Extensions.DependencyInjection;
using System;

namespace CmdSolutions.Shipping.NemoExpress
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddNemoExpress(this IServiceCollection services)
        {
            return services.AddNemoExpress("https://app.nemoexpress.ro/nemo/API/");
        }

        public static IServiceCollection AddNemoExpress(this IServiceCollection services, string url)
        {
            services
                .AddHttpClient("nemo-express", configure =>
                {
                    configure.BaseAddress = new Uri(url);
                })
                .AddTypedClient<INemoExpressClient, NemoExpressClient>();

            return services;
        }
    }
}
