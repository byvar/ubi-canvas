namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventTotalTrunksOpened : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2BF4E3E5;
	}
}

