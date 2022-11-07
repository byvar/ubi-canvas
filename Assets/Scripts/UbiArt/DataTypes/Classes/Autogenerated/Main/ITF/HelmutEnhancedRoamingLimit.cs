namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class HelmutEnhancedRoamingLimit : ActorComponent {
		public StringID StringID__0;
		public StringID StringID__1;
		public float float__2;
		public Enum_VH_0 Enum_VH_0__3;
		public uint uint__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			Enum_VH_0__3 = s.Serialize<Enum_VH_0>(Enum_VH_0__3, name: "Enum_VH_0__3");
			uint__4 = s.Serialize<uint>(uint__4, name: "uint__4");
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x0959EF43;
	}
}

