using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rand5.Services;
using System.Threading.Tasks;

namespace Rand5
{
    public class Program
    {
        /// <summary>
        /// This problem was asked by Two Sigma.
        /// Using a function rand7() that returns an integer from 1 to 7 (inclusive) with uniform probability, implement a function rand5() that returns an integer from 1 to 5 (inclusive).
        /// </summary>
        /// <param name="args"></param>
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
                    services.AddTransient<IRandomNumberGenerator, RandomNumberGenerator>();
                    services.AddHostedService<RandomNumberService>();
                });
        }
    }
}
