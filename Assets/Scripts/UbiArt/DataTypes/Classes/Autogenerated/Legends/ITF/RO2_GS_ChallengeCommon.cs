namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RM)]
	public partial class RO2_GS_ChallengeCommon : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC90BE700;
	}
}

