namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionStoryEvent_Template : CSerializable {
		public StringID storyEvent;
		public int value;
		public Enum_operator _operator;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			storyEvent = s.SerializeObject<StringID>(storyEvent, name: "storyEvent");
			value = s.Serialize<int>(value, name: "value");
			_operator = s.Serialize<Enum_operator>(_operator, name: "operator");
		}
		public enum Enum_operator {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x1C4666C9;
	}
}

