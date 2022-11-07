namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventCheckpointTriggerSequence : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC0981453;
	}
}

