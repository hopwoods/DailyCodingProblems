using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Rand5.Services
{
    public class RandomNumberService : IHostedService
    {
        private readonly ILogger _logger;
        private readonly IRandomNumberGenerator _randomNumberGenerator;

        public RandomNumberService(ILogger<RandomNumberService> logger, IHostApplicationLifetime appLifetime, IRandomNumberGenerator randomNumberGenerator)
        {
            _logger = logger;
            _randomNumberGenerator = randomNumberGenerator;

            appLifetime.ApplicationStarted.Register(OnStarted);
            appLifetime.ApplicationStopped.Register(OnStopped);
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Starting Service...");

           return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Stopping Service...");

            return Task.CompletedTask;
        }

        private void OnStarted()
        {
            _logger.LogInformation("Service Started");

            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine($"New random number {i} = {_randomNumberGenerator.Rand5()}");
            }
        }

        private void OnStopped()
        {
            _logger.LogInformation("5. OnStopped has been called.");
        }
    }
}
