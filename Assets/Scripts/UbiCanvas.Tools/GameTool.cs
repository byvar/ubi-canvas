using System.Collections.Generic;
using UbiArt;

namespace UbiCanvas.Tools
{
	public abstract class GameTool
	{
		protected Context CreateContext(string basePath = null, Mode? mode = null,
			bool enableSerializerLog = true, bool? loadAnimations = null, bool? loadAllPaths = null)
		{
			if (!mode.HasValue) mode = UnitySettings.GameMode;
			if (basePath == null) basePath = UnitySettings.GameDirs[mode.Value];

			Context context = new(basePath, Settings.FromMode(mode.Value),
				serializerLogger: enableSerializerLog ? new MapViewerSerializerLogger() : null,
				fileManager: new MapViewerFileManager(),
				systemLogger: new UnitySystemLogger(),
				asyncController: new UniTaskAsyncController());

			context.Loader.LoadAnimations = loadAnimations ?? UnitySettings.LoadAnimations;
			context.Loader.LoadAllPaths = loadAllPaths ?? UnitySettings.LoadAllPaths;

			return context;

		}

		public abstract string Name { get; }
		public virtual string Description => null;

		public List<GameToolRequirement> Requirements { get; } = new();
	}
}