using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using PrefixMapSum.Services;

namespace PrefixMapSum
{
    internal class Program
    {
        private static Task Main(string[] args)
        {
            using var host = CreateHostBuilder(args).Build();

            return host.RunAsync();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    services.AddTransient<IMapSum, PrefixMapSum>();
                    services.AddHostedService<PrefixMapService>();
                });
        }
    }
}
