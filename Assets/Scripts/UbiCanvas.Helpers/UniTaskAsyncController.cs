using System.Threading.Tasks;
using UbiArt;
using UbiCanvas.Helpers;

namespace UbiCanvas {
	public class UniTaskAsyncController : IAsyncController {
		public void StartAsync() => TimeController.StartStopwatch();
		public void StopAsync() => TimeController.StopStopwatch();

		public async Task Wait() => await TimeController.WaitFrame();
		public async Task WaitIfNecessary() => await TimeController.WaitIfNecessary();
	}
}