namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventSequenceFade : Event {
		public StringID name;
		public bool isFadeIn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			isFadeIn = s.Serialize<bool>(isFadeIn, name: "isFadeIn");
		}
		public override uint? ClassCRC => 0x3A768F0A;
	}
}

