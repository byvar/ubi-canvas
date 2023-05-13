using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UbiArt;
using Path = UbiArt.Path;

namespace UbiCanvas.Tools
{
	public class ExportEngineDataTool : ExportActionGameTool
	{
		public ExportEngineDataTool()
		{
			//Requirements.Add(new ModeGameToolRequirement(Settings.Mode.RaymanLegendsPC, Settings.Mode.RaymanAdventuresAndroid));
		}

		public override string Name => "Export Engine Data as JSON";
		public override string Description => "This tool exports all generic files in the EngineData folder to serialized JSON files";

		public override async Task InvokeAsync(string outputDir)
		{
			using Context context = CreateContext();
			await context.Loader.LoadInitial();

			string itfDir = context.Settings.ITFDirectory;

			foreach (string configFile in Directory.GetFiles(
				         System.IO.Path.Combine(context.BasePath, itfDir, "enginedata"),
				         "*.isg.ckd", SearchOption.AllDirectories))
			{
				string relativePath = configFile.Substring(configFile.IndexOf("enginedata"));
				context.Loader.LoadGenericFile(new Path(relativePath), x =>
				{
					string exportFile = System.IO.Path.Combine(outputDir, $"{relativePath}.json");
					Directory.CreateDirectory(System.IO.Path.GetDirectoryName(exportFile));
					File.WriteAllText(exportFile, JsonConvert.SerializeObject(x, Formatting.Indented));
				});
			}

			await context.Loader.LoadLoop();
		}
	}
}