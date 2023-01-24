using System.Threading.Tasks;

namespace UbiCanvas.Tools
{
	public abstract class ActionGameTool : GameTool
    {
		public abstract Task InvokeAsync();
    }
}