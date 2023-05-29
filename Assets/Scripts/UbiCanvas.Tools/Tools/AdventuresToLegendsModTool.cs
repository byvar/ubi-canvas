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

namespace UbiCanvas.Tools
{
	public class AdventuresToLegendsModTool : MultiActionGameTool
	{
		public AdventuresToLegendsModTool()
		{
			Actions.AddRange(new[]
			{
				new InvokableAction("Export current map in Legends format", async () => await ExportCurrentMap()),
				//new InvokableAction("Create config files from JSON", async () => await CreateSecureFATAsync()),
				new InvokableAction("Build & install project", async () => await BuildProject(install: true)),
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
					
					// Delete directory if it exists. Any manual mods need to be added into a different subdirectory.
					if(Directory.Exists(outputPath))
						Directory.Delete(outputPath, true);
					
					// Convert
					await new AdventuresToLegendsConverter().Convert(
							Controller.MainContext,
							UnitySettings.Tools_AdventuresToLegends_GamePath,
							outputPath,
							UnitySettings.Tools_AdventuresToLegends_ProjectPath);
				} else {
					UnityEngine.Debug.LogWarning("Please wait until the map is fully loaded before selecting this option.");
				}
			} else {
				UnityEngine.Debug.LogWarning("Please load a map before selecting this option.");
			}
		}

		#region Build (mostly a copy of BuildModIPKTool)
		private async Task BuildProject(bool install = false)
		{
			var mode = Settings.Mode.RaymanLegendsPC;
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
					patchBun.AddFile(path, data);
				} else {
					bun.AddFile(path, data);
				}
			}

			foreach (var dir in Directory.EnumerateDirectories(inputPath)) {
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
				Backup("secure_fat.gf");
				Copy("secure_fat.gf");
				Copy($"{bundleName}_{outputLoader.Settings.PlatformString}.ipk");
				Copy($"patch_{outputLoader.Settings.PlatformString}.ipk");
				outputContext.SystemLogger.LogInfo("Copied files to game directory.");
			}
		}

		private async Task CreateSecureFATAsync(Dictionary<string, UbiArt.Bundle.BundleFile> preLoadedBundles = null) {
			var mode = Settings.Mode.RaymanLegendsPC;
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
					Loader.ConfigureSerializeFlagsForExtension(ref w.flags, ref w.flagsOwn, "gf");
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