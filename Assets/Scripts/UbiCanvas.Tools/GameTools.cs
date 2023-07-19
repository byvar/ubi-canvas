namespace UbiCanvas.Tools
{
	public static class GameTools
	{
		public static GameTool[] Tools { get; } = 
		{
			new ExportEngineDataTool(),
			new ExportLocalisationTool(),
			new ExportTimelineTool(),
			new AdventuresSaveTool(),
			new BuildModIPKTool(),
			new ModeConversionTool(),
			new AdventuresToLegendsModTool(),
			new CRCCalculatorTool(),
		};
	}
}