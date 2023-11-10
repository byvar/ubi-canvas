using Cysharp.Threading.Tasks;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.CRC;
using UbiArt.ITF;
using UbiCanvas.Helpers;
using Path = UbiArt.Path;
using Stream = System.IO.Stream;
using UbiCanvas.Conversion;
using System.Diagnostics;

namespace UbiCanvas.Tools
{
	public class AdventuresToLegendsModTool : MultiActionGameTool
	{
		public AdventuresToLegendsModTool()
		{
			Actions.AddRange(new[]
			{
				new InvokableAction("Export current map in Legends format", async () => await ExportCurrentMap()),
				//new InvokableAction("Export costumes (requires manual edits)", async () => await ExportCostumes()),
				//new InvokableAction("Export rabbids (add into Legends directory!)", async () => await ExportRabbids()),
				//new InvokableAction("Build data files from JSON", async () => await BuildJSON()),
				new InvokableAction("Build & install project", async () => await BuildProject(install: true)),
				new InvokableAction("Fast clean, build & install project", async () => await BuildProject(install: true, clean: true, fullClean: false)),
				new InvokableAction("Full clean, build & install project", async () => await BuildProject(install: true, clean: true, fullClean: true)),
			});
        }

        public override string Name => "Adventures To Legends Mod Tool";
		public override string Description => "This tool contains actions used for the Adventures to Legends mod";

		private async Task ExportCurrentMap() {
			if (UnityEngine.Application.isPlaying) {
				if (GlobalLoadState.LoadState == GlobalLoadState.State.Finished) {
					// Get level name to calculate output path
					string lvlPath = UnitySettings.SelectedLevelFile;
					string sceneName = System.IO.Path.GetFileName(lvlPath);
					if(sceneName.Contains('.')) sceneName = sceneName.Substring(0, sceneName.IndexOf('.'));
					var subfolderName = sceneName;
					var outputPath = System.IO.Path.Combine(UnitySettings.Tools_AdventuresToLegends_ProjectPath, "data", subfolderName);
					UnityEngine.Debug.Log(outputPath);
					
					// Delete subdirectory if it exists. Any manual mods need to be added into a different subdirectory.
					if(Directory.Exists(outputPath))
						Directory.Delete(outputPath, true);

					// Convert
					using (var converter = new AdventuresToLegendsConverter(Controller.MainContext,
						UnitySettings.Tools_AdventuresToLegends_GamePath,
						UnitySettings.Tools_AdventuresToLegends_ProjectPath)) {
						await converter.Init();
						if (converter.MainContext.Settings.Game == Game.RM || converter.MainContext.Settings.Game == Game.RA) {
							await converter.ProcessScene(generateSGS: true);
							//await converter.ProcessAllLoadedScenes();
							await converter.ProcessNonScene();
						} else if (converter.MainContext.Settings.Platform == GamePlatform.Vita) {
							await converter.ProcessSceneVita(generateSGS: true);
						}
						await converter.Write(outputPath);
					}
				} else {
					UnityEngine.Debug.LogWarning("Please wait until the map is fully loaded before selecting this option.");
				}
			} else {
				UnityEngine.Debug.LogWarning("Please load a map before selecting this option.");
			}
		}

		private async Task ExportRabbids() {
			if (OpenFolderPanel == null)
				throw new Exception($"{nameof(OpenFolderPanel)} needs to be set!");

			var outputPath = System.IO.Path.Combine(UnitySettings.Tools_AdventuresToLegends_ProjectPath, "data", "rabbids");

			// Delete subdirectory if it exists. Any manual mods need to be added into a different subdirectory.
			if (Directory.Exists(outputPath))
				Directory.Delete(outputPath, true);

			// Convert
			string inputDir = OpenFolderPanel("Select an Adventures version or cancel to stop", null, "");
			while(!String.IsNullOrWhiteSpace(inputDir)) {
				using Context context = CreateContext(basePath: inputDir, mode: Mode.RaymanAdventuresAndroid, enableSerializerLog: false, loadAllPaths: true, loadAnimations: false);
				await context.Loader.LoadInitial();
				Path[] paths = new string[] {
					"world/rlc/common/enemy/rabbid/rabbid_shield.tsc",
					"world/rlc/common/enemy/rabbid/rabbid.act",
					"world/rlc/common/enemy/rabbid/rabbid_charge.act",
					"world/rlc/common/enemy/rabbid/rabbid_charge_direct.act",
					"world/rlc/common/enemy/rabbid/rabbid_chargeroaming.act",
					"world/rlc/common/enemy/rabbid/rabbid_roaming.act",
					"world/rlc/common/enemy/rabbid/components/rabbid.tpl",
				}.Select(p => new Path(p)).ToArray();
				foreach (var p in paths) {
					p.LoadObject(context);
				}
				await context.Loader.LoadLoop();


				using (var converter = new AdventuresToLegendsConverter(context,
					UnitySettings.Tools_AdventuresToLegends_GamePath,
					UnitySettings.Tools_AdventuresToLegends_ProjectPath, exportID: "rabbids")) {
					await converter.Init();
					var shieldScene = context.Cache.Get<ContainerFile<Scene>>(new Path("world/rlc/common/enemy/rabbid/rabbid_shield.tsc"));
					if (shieldScene?.obj != null) {
						await converter.ProcessScene(shieldScene.obj, generateSGS: false);
					}
					await converter.ProcessNonScene();
					await converter.Write(outputPath);
				}
				inputDir = OpenFolderPanel("Select an Adventures version or cancel to stop", null, "");
			}
		}

		private async Task ExportCostumes() {
			await Task.CompletedTask;
			//await new AdventuresToLegendsConverter().ConvertCostumes(UnitySettings.Tools_AdventuresToLegends_ProjectPath, Settings.Mode.RaymanMiniMacOS);
			//await new AdventuresToLegendsConverter().ConvertCostumes(UnitySettings.Tools_AdventuresToLegends_ProjectPath, Settings.Mode.RaymanAdventuresAndroid);
		}

		private async Task BuildJSON() {
			await new AtlasBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Build();
			await new HomeBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Build();
			await new LocalisationBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Build();
			await new TexturesBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Build();
			await new SoundsBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Build();
			await new WwiseSoundsBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Build();
			await new SimpleObjectBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Build();
			await new CombinedSceneBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Build();
			await new SceneConfigsBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Build();
			UnityEngine.Debug.Log("Finished building data from JSON files.");
		}

		private void Clean(bool fullClean = false) {
			new AtlasBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Clean();
			new HomeBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Clean();
			new LocalisationBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Clean();
			new TexturesBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Clean();
			new SoundsBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Clean();
			if (fullClean) {
				new WwiseSoundsBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Clean();
			}
			new SimpleObjectBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Clean();
			new CombinedSceneBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Clean();
			new SceneConfigsBuilder(UnitySettings.Tools_AdventuresToLegends_ProjectPath).Clean();
		}

		#region Build (mostly a copy of BuildModIPKTool)
		private async Task BuildProject(bool install = false, bool clean = false, bool fullClean = false)
		{
			if(clean) Clean(fullClean: fullClean);
			await BuildJSON();
			await TimeController.WaitIfNecessary();


			var mode = Mode.RaymanLegendsPC;
			var originalBundlesPath = UnitySettings.Tools_AdventuresToLegends_GamePath;
			var inputPath = System.IO.Path.Combine(UnitySettings.Tools_AdventuresToLegends_ProjectPath, "data").Replace('\\', '/');
			var outputPath = System.IO.Path.Combine(UnitySettings.Tools_AdventuresToLegends_ProjectPath, "output").Replace('\\', '/');
			var bundleName = "Adventures";

			var bun = new UbiArt.Bundle.BundleFile();

			using Context inputContext = CreateContext(
				basePath: originalBundlesPath,
				mode: mode,
				loadAnimations: false, loadAllPaths: false);
			var inputLoader = inputContext.Loader;
			await inputLoader.LoadBundles();
			var patchBun = new UbiArt.Bundle.BundleFile();

			void AddData(string stringPath, byte[] data) {
				Path path = new Path(stringPath, cooked: true);
				if (inputLoader != null && inputLoader.AnyBundleContainsFile(path)) {
					if(!patchBun.HasPreprocessedFile(path))
						patchBun.AddFile(path, data);
				} else {
					if(!bun.HasPreprocessedFile(path))
						bun.AddFile(path, data);
				}
			}

			// Use alphabetical order. To prioritize a file being added, prefix the mod name with _
			foreach (var dir in Directory.EnumerateDirectories(inputPath).OrderBy(p => p)) {
				//string dirPath = dir.Substring(inputPath.Length).Replace('\\', '/').Trim('/');
				string dirPath = dir.Replace('\\', '/').Trim('/');
				foreach (string file in Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories)) {
					string relativePath = file.Substring(dirPath.Length).Replace('\\', '/').TrimStart('/');
					byte[] data = File.ReadAllBytes(file);

					AddData(relativePath, data);
				}
			}


			using Context outputContext = CreateContext(
				basePath: outputPath,
				mode: mode,
				loadAnimations: false, loadAllPaths: false);
			var outputLoader = outputContext.Loader;
			await outputLoader.WriteBundle(System.IO.Path.Combine(outputPath, $"{bundleName}_{outputLoader.Settings.PlatformString}.ipk"), bun);
			if (patchBun != null && !patchBun.IsEmpty) {
				await outputLoader.WriteBundle(System.IO.Path.Combine(outputPath, $"patch_{outputLoader.Settings.PlatformString}.ipk"), patchBun);
			}

			outputContext.SystemLogger.LogInfo("Finished writing bundle(s).");
			await TimeController.WaitIfNecessary();
			
			Dictionary<string, UbiArt.Bundle.BundleFile> bundles = new Dictionary<string, UbiArt.Bundle.BundleFile>();
			bundles[bundleName] = bun;
			if (inputLoader != null) {
				foreach (var bundle in inputLoader.Bundles) {
					if(!bundles.ContainsKey(bundle.Key))
						bundles[bundle.Key] = bundle.Value;
				}
			}
			await CreateSecureFATAsync(preLoadedBundles: bundles);

			void Copy(string file) {
				var gameFile = System.IO.Path.Combine(originalBundlesPath, file);
				var inputFile = System.IO.Path.Combine(outputPath, file);
				try {
					if(File.Exists(inputFile)) File.Copy(inputFile, gameFile, true);
					else if (file == $"patch_{outputLoader.Settings.PlatformString}.ipk" && File.Exists(gameFile)) File.Delete(gameFile);
				} catch (IOException iox) {
					UnityEngine.Debug.Log(iox.Message);
				}
			}
			void Backup(string file) {
				var gameFile = System.IO.Path.Combine(originalBundlesPath, file);
				try {
					if (File.Exists(gameFile) && !File.Exists($"{gameFile}.BAK"))
						File.Copy(gameFile, $"{gameFile}.BAK", false);
				} catch (IOException iox) {
					UnityEngine.Debug.Log(iox.Message);
				}
			}

			if (install) {
				// Secure_FAT
				Backup("secure_fat.gf");
				Copy("secure_fat.gf");

				// Bundles
				Copy($"{bundleName}_{outputLoader.Settings.PlatformString}.ipk");
				Copy($"patch_{outputLoader.Settings.PlatformString}.ipk");

				// Localisation
				Backup("EngineData/Localisation/localisation.loc8");
				Copy("EngineData/Localisation/localisation.loc8");

				outputContext.SystemLogger.LogInfo("Copied files to game directory.");
			}
		}

		private async Task CreateSecureFATAsync(Dictionary<string, UbiArt.Bundle.BundleFile> preLoadedBundles = null) {
			var mode = Mode.RaymanLegendsPC;
			var originalBundlesPath = UnitySettings.Tools_AdventuresToLegends_GamePath;
			var outputPath = System.IO.Path.Combine(UnitySettings.Tools_AdventuresToLegends_ProjectPath, "output").Replace('\\', '/');

			var loadedBundles = preLoadedBundles;
			if (loadedBundles == null) loadedBundles = new Dictionary<string, UbiArt.Bundle.BundleFile>();

			string[] bundleNames = new string[] { "Bundle", "persistentLoading", "Adventures" };

			bool isMissingBundles = false;
			List<string> missingBundles = new List<string>();
			void UpdateMissingBundles() {
				missingBundles.Clear();
				foreach (var bundleName in bundleNames) {
					if (!loadedBundles.ContainsKey(bundleName)) {
						missingBundles.Add(bundleName);
					}
				}
				isMissingBundles = missingBundles.Any();
			}

			UpdateMissingBundles();

			// Load unloaded bundles
			if (isMissingBundles) {
				using Context inputContext = CreateContext(
					basePath: outputPath,
					mode: mode,
					loadAnimations: false, loadAllPaths: false);

				var inputLoader = inputContext.Loader;
				foreach (var missingBundle in missingBundles) {
					await inputLoader.LoadBundle(missingBundle);
					if (inputLoader.Bundles.ContainsKey(missingBundle)) {
						loadedBundles[missingBundle] = inputLoader.Bundles[missingBundle];
					}
				}
				UpdateMissingBundles();
			}
			if (isMissingBundles) {
				using Context originalBundlesContext = CreateContext(
					basePath: originalBundlesPath,
					mode: mode,
					loadAnimations: false, loadAllPaths: false);

				var inputLoader = originalBundlesContext.Loader;
				await inputLoader.LoadBundles();
				foreach (var missingBundle in missingBundles) {
					if (inputLoader.Bundles.ContainsKey(missingBundle)) {
						loadedBundles[missingBundle] = inputLoader.Bundles[missingBundle];
					}
				}
				UpdateMissingBundles();
			}
			if (isMissingBundles) {
				throw new Exception($"The following bundles could not be found: {string.Join(',',missingBundles.ToArray())}");
			}

			using Context context = CreateContext(
				basePath: outputPath,
				mode: mode,
				loadAnimations: false, loadAllPaths: false);
			//context.SystemLogger.LogInfo("Loaded bundle(s).");
			//await TimeController.WaitIfNecessary();

			// Create FAT
			var fat = new UbiArt.GlobalFat.GlobalFat();
			foreach (var bundleName in bundleNames) {
				var bun = loadedBundles[bundleName];
				UbiArt.GlobalFat.BundleDescriptor bd = fat.GetOrAddBundle(bundleName);

				foreach (var p in bun.packMaster.files) {
					var path = p.Item2;
					UbiArt.GlobalFat.FileDescriptor f = fat.GetOrAddFile(path);
					//fat.UnlinkFileAll(f);
					fat.LinkFile(f, bd);
				}
			}
			//context.SystemLogger.LogInfo("Finished creating secure_fat.");
			//await TimeController.WaitIfNecessary();

			// Serialize FAT & write it
			byte[] serializedData = null;
			using (MemoryStream stream = new MemoryStream()) {
				using (Writer writer = new Writer(stream, context.Settings.IsLittleEndian)) {
					CSerializerObjectBinaryWriter w = new CSerializerObjectBinaryWriter(context, writer);
					Loader.ConfigureSerializeFlagsForExtension(ref w.flags, ref w.properties, "gf");
					object toWrite = fat;
					w.Serialize(ref toWrite, GetType(), name: "FAT");
					serializedData = stream.ToArray();
				}
			}
			Util.ByteArrayToFile(System.IO.Path.Combine(outputPath, "secure_fat.gf"), serializedData);
			context.SystemLogger.LogInfo("Finished writing secure_fat.");
		}
		#endregion
	}
}