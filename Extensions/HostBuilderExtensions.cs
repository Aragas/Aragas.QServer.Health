using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Hosting
{
    public static class HostBuilderExtensions
    {
        public static IHostBuilder UseHealthChecks(this IHostBuilder hostBuilder) =>
            hostBuilder .ConfigureServices((hostContext, services) =>
            {
                services.AddHealthCheckPublisher();
            });
    }
}