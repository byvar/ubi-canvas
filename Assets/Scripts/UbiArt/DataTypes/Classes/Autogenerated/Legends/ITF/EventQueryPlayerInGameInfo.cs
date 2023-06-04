namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class EventQueryPlayerInGameInfo : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x912CA555;
	}
}

