namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_NPCSpawnerComponent : ActorComponent {
		public Path Path__0;
		public uint uint__1;
		public Enum_VH_0 Enum_VH_0__2;
		public Vec2d Vector2__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
			uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
			Enum_VH_0__2 = s.Serialize<Enum_VH_0>(Enum_VH_0__2, name: "Enum_VH_0__2");
			Vector2__3 = s.SerializeObject<Vec2d>(Vector2__3, name: "Vector2__3");
		}
		public enum Enum_VH_0 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_1" )] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x64E51342;
	}
}

