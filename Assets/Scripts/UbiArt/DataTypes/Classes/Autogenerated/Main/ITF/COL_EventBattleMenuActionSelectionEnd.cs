namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventBattleMenuActionSelectionEnd : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0FE763FF;
	}
}

