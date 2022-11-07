namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_GameGlobalsJoinDateCondition : online.GameGlobalsCondition {
		public online.DateTime date;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			date = s.SerializeObject<online.DateTime>(date, name: "date");
		}
		public override uint? ClassCRC => 0x7F5698BF;
	}
}

