namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventGameScreenPrepareToDestroy : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x58F22BB9;
	}
}

