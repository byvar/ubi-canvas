namespace UbiArt.ITF {
	public partial class SceneConfig {
		// Prepare component for conversion or returns a new component
		public virtual SceneConfig Convert(Context context, Settings oldSettings, Settings newSettings) => this;
	}
}
