namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_HomeCheckpointComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x32B0E56D;
	}
}

