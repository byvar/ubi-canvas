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
using UbiArt.Bundle;

namespace UbiCanvas.Tools
{
	public class ModeConversionTool : GameTool
	{

        public override string Name => "Mode Conversion Tool";
		public override string Description => "This tool converts certain file types between game modes";


		public async Task Convert() {
			using Context inputContext = CreateContext(
				basePath: UnitySettings.Tools_ModeConversion_InputPath,
				mode: UnitySettings.Tools_ModeConversion_InputMode,
				loadAnimations: false, loadAllPaths: false);

			using Context outputContext = CreateContext(
				basePath: UnitySettings.Tools_ModeConversion_OutputPath,
				mode: UnitySettings.Tools_ModeConversion_OutputMode,
				loadAnimations: false, loadAllPaths: false);


			// Create conversion settings
			var conversionSettings = new ConversionSettings() {
				OldSettings = inputContext.Settings,
			};
			outputContext.AddSettings<ConversionSettings>(conversionSettings);

			BundleFile outBundle = new BundleFile(outputContext);


			var inputPath = UnitySettings.Tools_ModeConversion_InputPath;
			var outputPath = UnitySettings.Tools_ModeConversion_OutputPath;
			List<Path> paths = new List<Path>();
			foreach (string file in Directory.GetFiles(inputPath, "*.*", SearchOption.AllDirectories)) {
				string relativePath = file.Substring(inputPath.Length).Replace('\\', '/').TrimStart('/');

				Path p = new Path(relativePath, cooked: true) { specialUncooked = true };
				p.LoadObject(inputContext, removeCooked: true);
				paths.Add(p);
			}
			await inputContext.Loader.LoadLoop();

			UnityEngine.Debug.Log("Loaded all files.");

			foreach (var p in paths) {
				outBundle.AddFile(p, p.Object);
			}
			await outputContext.Loader.WriteFilesRaw(outputPath, outBundle);

			UnityEngine.Debug.Log("Finished converting files.");
		}
	}
}