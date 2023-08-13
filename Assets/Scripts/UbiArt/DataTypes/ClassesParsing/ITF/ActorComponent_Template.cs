namespace UbiArt.ITF {
	public partial class ActorComponent_Template : CSerializable {
		// Prepare component for conversion or returns a new component
		public virtual ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) => this;
	}
}