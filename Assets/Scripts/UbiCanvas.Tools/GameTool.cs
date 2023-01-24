using System.Collections.Generic;
using UbiArt;

namespace UbiCanvas.Tools
{
	public abstract class GameTool
	{
		protected Context CreateContext()
		{
			Settings.Mode mode = UnitySettings.GameMode;
			
			Context context = new(UnitySettings.GameDirs[mode], Settings.Init(mode),
				serializerLogger: new MapViewerSerializerLogger(),
				fileManager: new MapViewerFileManager(),
				systemLogger: new UnitySystemLogger(),
				asyncController: new UniTaskAsyncController());

			context.Loader.LoadAnimations = UnitySettings.LoadAnimations;
			context.Loader.LoadAllPaths = UnitySettings.LoadAllPaths;

			return context;

		}

		public abstract string Name { get; }
		public virtual string Description => null;

		public List<GameToolRequirement> Requirements { get; } = new();
	}
}