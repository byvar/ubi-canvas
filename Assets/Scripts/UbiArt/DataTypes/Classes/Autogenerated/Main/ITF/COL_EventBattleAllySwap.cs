namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventBattleAllySwap : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA34446CA;
	}
}

