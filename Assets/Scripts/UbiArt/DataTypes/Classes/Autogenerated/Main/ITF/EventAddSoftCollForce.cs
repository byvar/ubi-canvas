namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventAddSoftCollForce : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD59AC7A8;
	}
}

