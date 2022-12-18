namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class StateSequences_Template : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBA3B4D86;
	}
}

