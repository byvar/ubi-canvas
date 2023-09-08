using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UbiArt;
using Path = UbiArt.Path;

namespace UbiCanvas.Tools
{
	public class ExportLocalisationTool : ExportActionGameTool
	{
		public ExportLocalisationTool()
		{
			//Requirements.Add(new ModeGameToolRequirement(Settings.Mode.RaymanLegendsPC, Settings.Mode.RaymanAdventuresAndroid));
		}

		public override string Name => "Export Localisation as JSON";
		public override string Description => "This tool exports the localisation of the game to a serialized JSON file";


		public class JSON_LocalisationData {
			public uint ID { get; set; }
			public Dictionary<string, string> Text { get; set; }
		}

		public override async Task InvokeAsync(string outputDir)
		{
			using Context context = CreateContext();
			await context.Loader.LoadInitial();

			var loc = context.Loader.localisation;

			var locales = loc.Locales;
			List<JSON_LocalisationData> locDataList = new List<JSON_LocalisationData>();
			foreach (var txt in loc.strings[0]) {
				var id = txt.Key;
				var jsonData = new JSON_LocalisationData() {
					ID = id.id,
					Text = new Dictionary<string, string>()
				};
				foreach (var lang in loc.strings) {
					if (lang.Value.ContainsKey(id)) {
						jsonData.Text[locales[lang.Key]] = lang.Value[id].text;
					}
				}
				locDataList.Add(jsonData);
			}

			string exportFile = System.IO.Path.Combine(outputDir, $"localisation_{context.Settings.Mode}.json");
			Directory.CreateDirectory(System.IO.Path.GetDirectoryName(exportFile));
			File.WriteAllText(exportFile, JsonConvert.SerializeObject(locDataList, Formatting.Indented));
		}
	}
}