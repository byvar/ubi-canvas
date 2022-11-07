namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventFadeToBlack : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x59BB46CC;
	}
}

