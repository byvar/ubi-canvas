namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_HomeCheckpointComponent : RO2_CheckpointComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xAFCB75E8;
	}
}

