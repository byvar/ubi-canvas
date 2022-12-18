namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_EventAddSoftCollForce : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x512ADAE3;
	}
}

