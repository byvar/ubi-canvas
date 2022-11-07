namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class GAWSpawnElement : CSerializable {
		public Enum_VH_0 Enum_VH_0__0;
		public Path Path__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
				Path__1 = s.SerializeObject<Path>(Path__1, name: "Path__1");
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
	}
}

