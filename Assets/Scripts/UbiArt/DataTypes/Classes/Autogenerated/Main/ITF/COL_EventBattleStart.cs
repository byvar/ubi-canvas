namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventBattleStart : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA67078A5;
	}
}

