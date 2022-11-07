namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventBattleTurnCompleted : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5514F29F;
	}
}

