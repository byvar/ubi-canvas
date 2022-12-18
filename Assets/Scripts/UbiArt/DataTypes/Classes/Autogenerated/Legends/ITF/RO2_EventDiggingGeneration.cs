namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_EventDiggingGeneration : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9A12B9ED;
	}
}

