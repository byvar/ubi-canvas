namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class EventOnStartDestroy : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x93A4E8B4;
	}
}

