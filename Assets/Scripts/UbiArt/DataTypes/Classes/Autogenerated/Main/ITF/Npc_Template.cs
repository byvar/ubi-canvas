namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class Npc_Template : ActorComponent_Template {
		public float float__0;
		public float float__1;
		public float float__2;
		public float float__3;
		public float float__4;
		public float float__5;
		public float float__6;
		public Path Path__7;
		public int int__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			float__4 = s.Serialize<float>(float__4, name: "float__4");
			float__5 = s.Serialize<float>(float__5, name: "float__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			Path__7 = s.SerializeObject<Path>(Path__7, name: "Path__7");
			int__8 = s.Serialize<int>(int__8, name: "int__8");
		}
		public override uint? ClassCRC => 0x4EB2F4D7;
	}
}

