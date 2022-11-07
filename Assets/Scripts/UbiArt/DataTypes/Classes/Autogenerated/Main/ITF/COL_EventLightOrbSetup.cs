namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventLightOrbSetup : Event {
		public Enum_type type;
		public float orbCount;
		public int picked;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			type = s.Serialize<Enum_type>(type, name: "type");
			orbCount = s.Serialize<float>(orbCount, name: "orbCount");
			picked = s.Serialize<int>(picked, name: "picked");
		}
		public enum Enum_type {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x519336F7;
	}
}

