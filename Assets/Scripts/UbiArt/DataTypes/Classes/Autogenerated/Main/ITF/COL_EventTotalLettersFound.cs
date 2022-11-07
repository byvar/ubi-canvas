namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventTotalLettersFound : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x082E7C97;
	}
}

