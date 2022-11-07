namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventPadRumbleStart : Event {
		public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
		}
		public override uint? ClassCRC => 0xAB107D88;
	}
}

