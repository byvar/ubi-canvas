namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_WikiShortcutCollectible : ActorComponent {
		public Path Path__0;
		public uint uint__1;
		public Vec2d Vector2__2;
		public Vec2d Vector2__3;
		public uint uint__4;
		public Path Path__5;
		public Vec2d Vector2__6;
		public float float__7;
		public Path Path__8;
		public Vec2d Vector2__9;
		public bool bool__10;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
			uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
			Vector2__2 = s.SerializeObject<Vec2d>(Vector2__2, name: "Vector2__2");
			Vector2__3 = s.SerializeObject<Vec2d>(Vector2__3, name: "Vector2__3");
			uint__4 = s.Serialize<uint>(uint__4, name: "uint__4");
			Path__5 = s.SerializeObject<Path>(Path__5, name: "Path__5");
			Vector2__6 = s.SerializeObject<Vec2d>(Vector2__6, name: "Vector2__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			Path__8 = s.SerializeObject<Path>(Path__8, name: "Path__8");
			Vector2__9 = s.SerializeObject<Vec2d>(Vector2__9, name: "Vector2__9");
			bool__10 = s.Serialize<bool>(bool__10, name: "bool__10");
		}
		public override uint? ClassCRC => 0xA54374C5;
	}
}

