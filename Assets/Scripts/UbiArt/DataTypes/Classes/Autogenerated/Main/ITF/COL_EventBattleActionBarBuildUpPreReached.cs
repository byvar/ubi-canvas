namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventBattleActionBarBuildUpPreReached : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0C6578C0;
	}
}

