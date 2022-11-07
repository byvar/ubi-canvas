namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionConditionStoryEvent_Template : CSerializable {
		public StringID storyEvent;
		public int value;
		public bool negated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			storyEvent = s.SerializeObject<StringID>(storyEvent, name: "storyEvent");
			value = s.Serialize<int>(value, name: "value");
			negated = s.Serialize<bool>(negated, name: "negated", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x27B0EFA9;
	}
}

