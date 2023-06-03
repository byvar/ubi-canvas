namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class EventMapRestart : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x10690366;
	}
}

