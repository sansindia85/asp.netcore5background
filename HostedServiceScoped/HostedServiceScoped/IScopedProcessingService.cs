using System.Threading;
using System.Threading.Tasks;

namespace HostedServiceScoped
{
    interface IScopedProcessingService
    {
        Task DoWork(CancellationToken stoppingToken);
    }
}
