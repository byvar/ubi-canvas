namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventGhostOnRecordingFrame : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x43F34BD9;
	}
}

