namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventDestroySpawned : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFF01A6B7;
	}
}

