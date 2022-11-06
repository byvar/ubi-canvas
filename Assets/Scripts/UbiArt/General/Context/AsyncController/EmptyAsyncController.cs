using System.Diagnostics;
using System.Threading.Tasks;

namespace UbiArt
{
    /// <summary>
    /// An empty async controller which will always run synchronously
    /// </summary>
    public class EmptyAsyncController : IAsyncController {
        public void StartAsync() { }
        public void StopAsync() { }

        public Task Wait() => Task.CompletedTask;
        public Task WaitIfNecessary() => Task.CompletedTask;
    }
}