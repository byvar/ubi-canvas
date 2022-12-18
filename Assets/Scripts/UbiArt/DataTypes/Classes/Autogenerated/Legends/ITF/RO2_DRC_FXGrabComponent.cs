namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_DRC_FXGrabComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC3233699;
	}
}

