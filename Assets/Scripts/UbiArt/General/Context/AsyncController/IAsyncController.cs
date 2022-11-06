using System;
using System.Threading.Tasks;

namespace UbiArt
{
    public interface IAsyncController
    {
        public Task Wait();
        public void StartAsync();
        public void StopAsync();
        public Task WaitIfNecessary(); 
    }
}