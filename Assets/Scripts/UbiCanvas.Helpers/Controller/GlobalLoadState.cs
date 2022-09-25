using Cysharp.Threading.Tasks;
using System.Diagnostics;

namespace UbiCanvas.Helpers {
	public class GlobalLoadState {
        public enum State {
            None,
            LoadingFiles,
            Loading,
            Initializing,
            Error,
            Finished
        }
        public static State LoadState { get; set; }
        public static string DetailedState { get; set; } = "Starting";
    }
}
