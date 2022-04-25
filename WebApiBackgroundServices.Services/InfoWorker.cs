using Microsoft.Extensions.Hosting;

namespace WebApiBackgroundServices.Services
{
    public class InfoWorker : IHostedService
    {
        private int executionCount = 0;
        private Timer _timer = null!;
        private string _message = "Mensagem Inicial....";

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Process Started {nameof(InfoWorker)} !!!");

            _timer = new Timer(DoWork, null, TimeSpan.FromSeconds(5),
            TimeSpan.FromSeconds(1));

            return Task.CompletedTask;
        }

        private void DoWork(object? state)
        {
            Console.WriteLine($"{DateTime.Now:o} =>{_message}");
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Process Finished {nameof(InfoWorker)} !!!");

            return Task.CompletedTask;
        }
    }
}