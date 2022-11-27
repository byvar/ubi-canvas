namespace UbiArt.ITF {
	public partial class ActorComponent_Template : CSerializable {
		// Prepare component for conversion or returns a new component
		public virtual ActorComponent_Template Convert(Settings oldSettings, Settings newSettings) => this;
	}
}