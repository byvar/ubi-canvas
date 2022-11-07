namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_GunShot : ActorComponent {
		public bool bool__0;
		public Path Path__1;
		public Enum_VH_0 Enum_VH_0__2;
		public uint uint__3;
		public uint uint__4;
		public float float__5;
		public float float__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
				Path__1 = s.SerializeObject<Path>(Path__1, name: "Path__1");
				Enum_VH_0__2 = s.Serialize<Enum_VH_0>(Enum_VH_0__2, name: "Enum_VH_0__2");
				uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
				uint__4 = s.Serialize<uint>(uint__4, name: "uint__4");
				float__5 = s.Serialize<float>(float__5, name: "float__5");
				float__6 = s.Serialize<float>(float__6, name: "float__6");
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0"  )] Value_0 = 0,
			[Serialize("Value_1"  )] Value_1 = 1,
			[Serialize("Value_2"  )] Value_2 = 2,
			[Serialize("Value_4"  )] Value_4 = 4,
			[Serialize("Value_8"  )] Value_8 = 8,
			[Serialize("Value_12" )] Value_12 = 12,
			[Serialize("Value_14" )] Value_14 = 14,
			[Serialize("Value_16" )] Value_16 = 16,
			[Serialize("Value_32" )] Value_32 = 32,
			[Serialize("Value_33" )] Value_33 = 33,
			[Serialize("Value_64" )] Value_64 = 64,
			[Serialize("Value_128")] Value_128 = 128,
			[Serialize("Value__1" )] Value__1 = -1,
		}
		public override uint? ClassCRC => 0xCCECE843;
	}
}

