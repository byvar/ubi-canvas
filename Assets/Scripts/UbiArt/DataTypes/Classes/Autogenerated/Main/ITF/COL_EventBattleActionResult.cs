namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventBattleActionResult : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x714C4E87;
	}
}

