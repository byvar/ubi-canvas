namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventSetFloatInput : Event {
		public StringID inputName;
		public float inputValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			inputName = s.SerializeObject<StringID>(inputName, name: "inputName");
			inputValue = s.Serialize<float>(inputValue, name: "inputValue");
		}
		public override uint? ClassCRC => 0x302A1685;
	}
}

