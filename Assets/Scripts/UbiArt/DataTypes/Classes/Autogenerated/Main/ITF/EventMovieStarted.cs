namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class EventMovieStarted : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x61EE521A;
	}
}

