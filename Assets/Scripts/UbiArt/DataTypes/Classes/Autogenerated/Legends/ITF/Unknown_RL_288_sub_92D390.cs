namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_GameSequence_StartLevel : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6948A04F;
	}
}

