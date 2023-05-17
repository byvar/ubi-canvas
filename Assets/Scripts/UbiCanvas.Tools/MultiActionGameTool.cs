using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UbiCanvas.Tools
{
	public abstract class MultiActionGameTool : GameTool
    {
	    protected MultiActionGameTool()
	    {
		    Actions = new List<InvokableAction>();
	    }

	    public List<InvokableAction> Actions { get; }

		public record InvokableAction(string Name, Func<Task> Action);
    }
}