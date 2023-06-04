namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RM)]
	public partial class RO2_GS_ChallengeEndurance : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x93E13F56;
	}
}

