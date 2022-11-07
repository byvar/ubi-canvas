namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventBattleActionIntro : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC606D460;
	}
}

