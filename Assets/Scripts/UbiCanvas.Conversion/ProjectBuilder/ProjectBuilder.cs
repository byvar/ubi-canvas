using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.Bundle;

namespace UbiCanvas.Conversion {
	public abstract class ProjectBuilder {

		public string ProjectPath { get; set; }

		public virtual string BuildPath => BuildsToData ? System.IO.Path.Combine(ProjectPath, "data", $"_build_{ID}") : null;

		public virtual bool BuildsToData => true;

		public abstract string ID { get; }

		public Context TargetContext { get; set; } // Only during build!
		public BundleFile Bundle { get; set; }

		public ProjectBuilder(string projectPath) {
			ProjectPath = projectPath;
			Bundle = new BundleFile();
		}

		protected abstract Task BuildInternal();

		public virtual async Task Build() {
			using (TargetContext = CreateContext(Settings.Mode.RaymanLegendsPC)) {
				TargetContext?.SystemLogger?.LogInfo($"Building: {ID}");
				await TargetContext.Loader.LoadInitial();
				await BuildInternal();
				await BuildBundle();
			}
		}

		public virtual void Clean() {
			if(!BuildsToData) return;

			// Removes build directory and all contents
			if(System.IO.Directory.Exists(BuildPath))
				System.IO.Directory.Delete(BuildPath, true);
		}

		public virtual async Task BuildBundle() {
			if(!BuildsToData) return;
			if(!Bundle.IsEmpty) await TargetContext.Loader.WriteFilesRaw(BuildPath, Bundle);
		}

		protected Context CreateContext(Settings.Mode mode,
			string basePath = null,
			bool enableSerializerLog = true) {
			if (basePath == null) basePath = UnitySettings.GameDirs[mode];

			Context context = new(basePath, Settings.Init(mode),
				serializerLogger: enableSerializerLog ? new MapViewerSerializerLogger() : null,
				fileManager: new MapViewerFileManager(),
				systemLogger: new UnitySystemLogger(),
				asyncController: new UniTaskAsyncController());

			return context;

		}

		protected async Task<T> LoadFileFromPatchData<T>(Context context, string file) where T : ICSerializable, new() {
			Path uncookedPath = new Path(file);
			Path cookedPath = uncookedPath.CookedPath(context);
			var cookedFullPath = cookedPath.FullPath;
			var inPath = System.IO.Path.Combine(ProjectPath, "data");
			T outputObject = default;

			foreach (var dir in System.IO.Directory.EnumerateDirectories(inPath).OrderBy(p => p)) {
				var fullPath = System.IO.Path.Combine(dir, cookedFullPath);
				if (System.IO.File.Exists(fullPath)) {
					byte[] data = System.IO.File.ReadAllBytes(fullPath);
					context.Loader.Load(new ArchiveMemory() { AMData = data }, uncookedPath.filename, (extS) => {
						outputObject = extS.SerializeObject<T>(outputObject);
					});
					await context.Loader.LoadLoop();
					return outputObject;
				}
			}
			return default;
		}

		protected bool FileIsAlreadyBuilt(Path path) {
			if(!path.IsCooked(TargetContext)) 
				return FileIsAlreadyBuilt(path.CookedPath(TargetContext));
			
			return (Bundle?.ContainsFile(path) ?? false) || System.IO.File.Exists(System.IO.Path.Combine(BuildPath, path.FullPath));
		}
		protected bool IsBuilt(string path) {
			return System.IO.File.Exists(System.IO.Path.Combine(BuildPath, path));
		}
	}
}
