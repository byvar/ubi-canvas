namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Ladder : W1W_InteractiveGenComponent {
		public float float__0;
		public float float__1;
		public Enum_VH_0_ Enum_VH_0__2;
		public bool bool__3;
		public bool bool__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			Enum_VH_0__2 = s.Serialize<Enum_VH_0_>(Enum_VH_0__2, name: "Enum_VH_0__2");
			bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
			bool__4 = s.Serialize<bool>(bool__4, name: "bool__4");
		}
		public enum Enum_VH_0_ : uint {
			[Serialize("Wood" )] Wood  = 0x09DF17B2,
			[Serialize("Metal")] Metal = 0x8A0AFB6E,
		}
		public override uint? ClassCRC => 0xFBE7ADAB;
	}
}

