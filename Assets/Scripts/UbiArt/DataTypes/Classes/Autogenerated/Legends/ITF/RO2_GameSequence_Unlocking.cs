namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_GameSequence_Unlocking : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA11F5C99;
	}
}

