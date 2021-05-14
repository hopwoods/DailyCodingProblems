using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PrefixMapSum.Services
{
    public class PrefixMapService : IHostedService
    {
        private readonly ILogger _logger;
        private readonly IMapSum _mapSum;

        public PrefixMapService(ILogger<PrefixMapService> logger, IHostApplicationLifetime appLifetime, IMapSum mapSum)
        {
            _logger = logger;
            _mapSum = mapSum;

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

            _mapSum.Map.Add(new KeyValuePair<string, int>("columnar", 3));
            Console.WriteLine($"Added Key = 'columnar' with value of 3");

            _mapSum.Map.Add(new KeyValuePair<string, int>("column", 2));
            Console.WriteLine($"Added Key = 'column' with value of 2");

            var sum = _mapSum.Sum("col");

            Console.WriteLine($"Sum of keys with 'col' value = {sum}");
        }

        private void OnStopped()
        {
            _logger.LogInformation("5. OnStopped has been called.");
        }
    }
}
