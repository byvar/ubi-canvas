﻿namespace UbiCanvas.Tools
{
	public static class GameTools
	{
		public static GameTool[] Tools { get; } = 
		{
			new ExportEngineDataTool(),
			new AdventuresSaveTool(),
		};
	}
}