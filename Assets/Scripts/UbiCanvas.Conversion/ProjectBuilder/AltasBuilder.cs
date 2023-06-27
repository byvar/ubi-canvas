using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;

namespace UbiCanvas.Conversion {
	public class AtlasBuilder : ProjectBuilder {

		public AtlasBuilder(string path) : base(path) { }

		public override string ID => "atlas";

		protected override async Task BuildInternal() {
			await Task.CompletedTask;
			var uvManagerPath = System.IO.Path.Combine(ProjectPath, "json", "atlascontainer");

			var files = System.IO.Directory.Exists(uvManagerPath) ? System.IO.Directory.GetFiles(uvManagerPath, "*.json") : null;
			if (files != null && files.Any()) {
				files = files.OrderBy(f => f).ToArray();
				Dictionary<string, UbiArt.UV.UVAtlas> newUVEntries = new Dictionary<string, UbiArt.UV.UVAtlas>();
				
				var uvManager = TargetContext.Loader.uvAtlasManager;

				foreach (var f in files) {
					var json = System.IO.File.ReadAllText(f);
					var curUVEntries = JsonConvert.DeserializeObject<Dictionary<string, UbiArt.UV.UVAtlas>>(json);
					foreach (var entry in curUVEntries) {
						if (!newUVEntries.ContainsKey(entry.Key)) // For high priority entries, prefix them with _ or something
							newUVEntries[entry.Key] = entry.Value;
					}
				}
				foreach (var entry in newUVEntries) {
					var path = new Path(entry.Key, cooked: false);
					if (!uvManager.atlas.ContainsKey(path.stringID))
						uvManager.atlas.Add(path.stringID, entry.Value);
				}

				Bundle.AddFile(TargetContext.Loader.CookedPaths[new Path("atlascontainer").stringID], uvManager);
			}
		}
	}
}
