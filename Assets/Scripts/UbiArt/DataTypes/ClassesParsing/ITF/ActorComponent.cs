namespace UbiArt.ITF {
	public partial class ActorComponent : CSerializable {
		// Prepare component for conversion or returns a new component
		public virtual ActorComponent Convert(Context context, Actor actor, Settings oldSettings, Settings newSettings) => this;
	}
}