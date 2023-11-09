using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UbiArt;
using Path = UbiArt.Path;

namespace UbiCanvas.Tools
{
	public class ExportTimelineTool : GameTool
	{
		public ExportTimelineTool()
		{
			//Requirements.Add(new ModeGameToolRequirement(Settings.Mode.RaymanLegendsPC, Settings.Mode.RaymanAdventuresAndroid));
		}

		public override string Name => "Export File Timeline";
		public override string Description => "This tool exports a timeline text file based on the packed file dates.";

		public async Task ExportSingleTimelineAsync(string inputDir, string outputDir)
		{
			using Context context = CreateContext(basePath: inputDir);

			List<KeyValuePair<DateTime, string>> timelineList = new List<KeyValuePair<DateTime, string>>();
			await context.Loader.LoadBundles();

			foreach (var bPair in context.Loader.Bundles) {
				var files = bPair.Value?.packMaster?.files;
				if (files != null) {
					foreach (var f in files) {
						var dateLastWriteAccess = DateTime.FromFileTime((long)f.Item1.timeStamp);
						timelineList.Add(new KeyValuePair<DateTime, string>(dateLastWriteAccess, f.Item2.FullPath));
					}
				}
			}
			timelineList.Sort((x, y) => x.Key.CompareTo(y.Key));

			if (timelineList.Any()) {
				StringBuilder b = new StringBuilder();
				foreach (var kv in timelineList) {
					b.AppendLine($"{kv.Key:ddd, dd/MM/yyyy - HH:mm:ss}\t{kv.Value}");
				}
				var lastDate = timelineList.Last().Key;

				File.WriteAllText(System.IO.Path.Combine(outputDir, $"timeline_{context.Settings.Mode}_{lastDate:yyyyMMdd}.txt"), b.ToString());
			}
		}

		public async Task ExportMultipleTimelineAsync(string inputDir) {
			var subDirs = System.IO.Directory.GetDirectories(inputDir, "*", SearchOption.TopDirectoryOnly);
			foreach (var dir in subDirs) {
				await ExportSingleTimelineAsync(dir, dir);
			}
		}
	}
}