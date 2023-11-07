using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion {
	public class SceneConfigsBuilder : ProjectBuilder {

		public SceneConfigsBuilder(string path) : base(path) { }

		public override string ID => "sgs";

		protected override async Task BuildInternal() {
			await Task.CompletedTask;

			var inPath = System.IO.Path.Combine(ProjectPath, "data");

			bool addedSGS = false;
			Path pSgsContainer = new Path("sgscontainer");
			UbiArt.SceneConfig.SceneConfigManager sceneConfigManager = null;

			// Use alphabetical order. To prioritize a file being added, prefix the mod name with _
			foreach (var dir in System.IO.Directory.EnumerateDirectories(inPath).OrderBy(p => p)) {
				//string dirPath = dir.Substring(inputPath.Length).Replace('\\', '/').Trim('/');
				string dirPath = dir.Replace('\\', '/').Trim('/');
				foreach (string file in System.IO.Directory.GetFiles(dir, "*.*", System.IO.SearchOption.AllDirectories)) {
					string relativePath = file.Substring(dirPath.Length).Replace('\\', '/').TrimStart('/');

					var cookedPath = new Path(relativePath, cooked: true);
					var uncookedPath = cookedPath.UncookedPath(TargetContext);
					if (uncookedPath.FullPath.EndsWith(".sgs")) {

						if (!addedSGS) {
							TargetContext.Loader.LoadFile<UbiArt.SceneConfig.SceneConfigManager>(pSgsContainer, result => sceneConfigManager = result);
							await TargetContext.Loader.LoadLoop();
							addedSGS = true;
						}

						var fullPath = uncookedPath.FullPath;
						var iscPath = new Path(fullPath.Substring(0, fullPath.Length - 4) + ".isc");
						var sgs = await LoadFileFromPatchData<ContainerFile<Generic<SceneConfig>>>(TargetContext, fullPath);
						if (sgs?.obj?.obj != null) {
							sceneConfigManager.sgsMap[iscPath.stringID] = sgs.obj;
						}
					}
				}
			}
			if (addedSGS) {
				Bundle.AddFile(TargetContext.Loader.CookedPaths[pSgsContainer.stringID], sceneConfigManager);
			}
		}
	}
}
