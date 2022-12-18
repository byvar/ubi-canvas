namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_EventReleaseRope : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x482CC5F9;
	}
}

