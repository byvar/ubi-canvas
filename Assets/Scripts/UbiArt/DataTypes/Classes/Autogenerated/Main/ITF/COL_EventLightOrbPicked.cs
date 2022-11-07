namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventLightOrbPicked : Event {
		public float value;
		public Enum_type type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			value = s.Serialize<float>(value, name: "value");
			type = s.Serialize<Enum_type>(type, name: "type");
		}
		public enum Enum_type {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x8B9DB973;
	}
}

