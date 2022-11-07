namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class WikiItem : CSerializable {
		public uint uint__0;
		public Enum_VH_0 Enum_VH_0__1;
		public Path Path__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
			Enum_VH_0__1 = s.Serialize<Enum_VH_0>(Enum_VH_0__1, name: "Enum_VH_0__1");
			Path__2 = s.SerializeObject<Path>(Path__2, name: "Path__2");
		}
		public enum Enum_VH_0 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
		}
	}
}

