using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.Localisation;
using UbiCanvas.Conversion.Json;

namespace UbiCanvas.Conversion {
	public class LocalisationBuilder : ProjectBuilder {

		public LocalisationBuilder(string projectPath) : base(projectPath) { }

		public override string ID => "localisation";
		public override bool BuildsToData => false;

		protected override async Task BuildInternal() {
			await Task.CompletedTask;
			var locJSONPath = System.IO.Path.Combine(ProjectPath, "json", "localisation");

			var files = System.IO.Directory.Exists(locJSONPath) ? System.IO.Directory.GetFiles(locJSONPath, "*.json") : null;
			if (files != null && files.Any()) {
				files = files.OrderBy(f => f).ToArray();
				
				var loc = TargetContext.Loader.localisation;
				Path pLoc = new Path("EngineData/Localisation/", "localisation.loc8") { specialUncooked = true };
				var locales = loc.Locales;
				Dictionary<string, int> langCodeMap = Enumerable.Range(0, locales.Length).ToDictionary(l => locales[l].ToUpperInvariant());

				foreach (var f in files) {
					var json = System.IO.File.ReadAllText(f);
					var locData = JsonConvert.DeserializeObject<List<JSON_LocalisationData>>(json);
					foreach (var l in locData) {
						var id = new LocalisationId(l.ID);
						foreach (var lang in l.Text) {
							var k = lang.Key.ToUpperInvariant();
							if (langCodeMap.ContainsKey(k)) {
								var langIndex = langCodeMap[k];
								if (loc.strings.ContainsKey(langIndex)) {
									var langMap = loc.strings[langIndex];
									langMap.Add(id, new LocText() { text = lang.Value });
								}
							} else {
								throw new Exception($"Lang code not found: {lang.Key}");
							}
						}
					}
				}

				Bundle.AddFile(pLoc, loc);
			}
		}

		public override async Task BuildBundle() {
			var outPath = System.IO.Path.Combine(ProjectPath, "output");
			await TargetContext.Loader.WriteFilesRaw(outPath, Bundle);
		}
	}
}
