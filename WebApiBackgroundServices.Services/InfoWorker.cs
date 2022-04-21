using Microsoft.Extensions.Hosting;

namespace WebApiBackgroundServices.Services
{
    public class InfoWorker : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Process Started {nameof(InfoWorker)} !!!");

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Process Finished {nameof(InfoWorker)} !!!");

            return Task.CompletedTask;
        }
    }
}