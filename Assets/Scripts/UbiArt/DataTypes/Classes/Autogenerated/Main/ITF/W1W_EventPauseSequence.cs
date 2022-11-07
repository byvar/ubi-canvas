namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventPauseSequence : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4FBBF127;
	}
}

