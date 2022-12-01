namespace UbiArt.ITF {
	public partial class ActorComponent : CSerializable {
		// Prepare component for conversion or returns a new component
		public virtual ActorComponent Convert(Actor actor, Settings oldSettings, Settings newSettings) => this;
	}
}