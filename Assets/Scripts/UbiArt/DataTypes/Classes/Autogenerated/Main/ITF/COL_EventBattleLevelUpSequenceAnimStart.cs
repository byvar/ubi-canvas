namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventBattleLevelUpSequenceAnimStart : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD7272AD7;
	}
}

