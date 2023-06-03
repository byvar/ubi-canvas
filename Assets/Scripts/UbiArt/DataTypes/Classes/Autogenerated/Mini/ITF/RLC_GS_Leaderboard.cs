namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_GS_Leaderboard : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x083B9B00;
	}
}

