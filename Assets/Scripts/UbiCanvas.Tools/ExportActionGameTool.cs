using System.Threading.Tasks;

namespace UbiCanvas.Tools
{
	public abstract class ExportActionGameTool : GameTool
	{
		public abstract Task InvokeAsync(string outputDir);
	}
}