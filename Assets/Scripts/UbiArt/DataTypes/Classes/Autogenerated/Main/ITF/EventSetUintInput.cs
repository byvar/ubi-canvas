namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventSetUintInput : Event {
		public StringID inputName;
		public uint inputValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			inputName = s.SerializeObject<StringID>(inputName, name: "inputName");
			inputValue = s.Serialize<uint>(inputValue, name: "inputValue");
		}
		public override uint? ClassCRC => 0x603D2117;
	}
}

