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

namespace UbiCanvas.Tools
{
	public class BuildModIPKTool : MultiActionGameTool
	{
		public BuildModIPKTool()
		{
			Actions.AddRange(new[]
			{
				new InvokableAction("Create single IPK from folder", async () => await CreateIPKAsync(false)),
				new InvokableAction("Create single IPK with patch", async () => await CreateIPKAsync(true)),
				new InvokableAction("Create secure_fat file only", async () => await CreateSecureFATAsync(true)),
			});
			//Requirements.Add(new ModeGameToolRequirement(Settings.Mode.RaymanLegendsPC));
        }

        public override string Name => "Mod IPK Creator";
		public override string Description => "This tool builds patch & mod IPK files, for Rayman Legends only";

		private async Task CreateIPKAsync(bool patch)
		{
			var mode = UnitySettings.Tools_BuildModIPK_GameMode;
			var originalBundlesPath = UnitySettings.Tools_BuildModIPK_OriginalBundlesPath;
			var inputPath = UnitySettings.Tools_BuildModIPK_InputPath;
			var outputPath = UnitySettings.Tools_BuildModIPK_OutputPath;
			var bundleName = UnitySettings.Tools_BuildModIPK_BundleBaseName;

			var bun = new UbiArt.Bundle.BundleFile();
			UbiArt.Bundle.BundleFile patchBun = null;
			Loader inputLoader = null;

			if (patch) {
				using Context inputContext = CreateContext(
					basePath: originalBundlesPath,
					mode: mode,
					loadAnimations: false, loadAllPaths: false);

				patchBun = new UbiArt.Bundle.BundleFile();

				inputLoader = inputContext.Loader;
				await inputLoader.LoadBundles();
			}

			void AddData(string stringPath, byte[] data) {
				Path path = new Path(stringPath, cooked: true);
				if (inputLoader != null && inputLoader.AnyBundleContainsFile(path)) {
					patchBun.AddFile(path, data);
				} else {
					bun.AddFile(path, data);
				}
			}

			foreach (string file in Directory.GetFiles(inputPath, "*.*", SearchOption.AllDirectories)) {
				string relativePath = file.Substring(inputPath.Length).Replace('\\','/').TrimStart('/');
				byte[] data = File.ReadAllBytes(file);

				AddData(relativePath, data);
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
			if (UnitySettings.Tools_BuildModIPK_CreateSecureFatAfterIPK) {
				Dictionary<string, UbiArt.Bundle.BundleFile> bundles = new Dictionary<string, UbiArt.Bundle.BundleFile>();
				bundles[bundleName] = bun;
				if (inputLoader != null) {
					foreach (var bundle in inputLoader.Bundles) {
						if(!bundles.ContainsKey(bundle.Key))
							bundles[bundle.Key] = bundle.Value;
					}
				}
				await CreateSecureFATAsync(patch, preLoadedBundles: bundles);
			}
		}

		private async Task CreateSecureFATAsync(bool patch, Dictionary<string, UbiArt.Bundle.BundleFile> preLoadedBundles = null) {
			var mode = UnitySettings.Tools_BuildModIPK_GameMode;
			var originalBundlesPath = UnitySettings.Tools_BuildModIPK_OriginalBundlesPath;
			var inputPath = UnitySettings.Tools_BuildModIPK_InputPath;
			var outputPath = UnitySettings.Tools_BuildModIPK_OutputPath;
			var bundleOrder = UnitySettings.Tools_BuildModIPK_BundleOrder;

			var loadedBundles = preLoadedBundles;
			if (loadedBundles == null) loadedBundles = new Dictionary<string, UbiArt.Bundle.BundleFile>();

			string[] bundleNames = bundleOrder.Split(',').Select(bn => bn.Trim()).ToArray();
			if (bundleNames == null || bundleNames.Length == 0) {
				throw new Exception($"No bundle order provided (ex.: \"Bundle,persistentLoading,mod\")");
			}

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
				Loader inputLoader = null;
				using Context inputContext = CreateContext(
					basePath: outputPath,
					mode: mode,
					loadAnimations: false, loadAllPaths: false);

				inputLoader = inputContext.Loader;
				foreach (var missingBundle in missingBundles) {
					await inputLoader.LoadBundle(missingBundle);
					if (inputLoader.Bundles.ContainsKey(missingBundle)) {
						loadedBundles[missingBundle] = inputLoader.Bundles[missingBundle];
					}
				}
				UpdateMissingBundles();
			}
			if (isMissingBundles) {
				Loader inputLoader = null;

				if (patch) {
					using Context originalBundlesContext = CreateContext(
						basePath: originalBundlesPath,
						mode: mode,
						loadAnimations: false, loadAllPaths: false);

					inputLoader = originalBundlesContext.Loader;
					await inputLoader.LoadBundles();
					foreach (var missingBundle in missingBundles) {
						if (inputLoader.Bundles.ContainsKey(missingBundle)) {
							loadedBundles[missingBundle] = inputLoader.Bundles[missingBundle];
						}
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
			context.SystemLogger.LogInfo("Loaded bundle(s).");
			await TimeController.WaitIfNecessary();

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
			context.SystemLogger.LogInfo("Finished creating secure_fat.");
			await TimeController.WaitIfNecessary();

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
	}
}