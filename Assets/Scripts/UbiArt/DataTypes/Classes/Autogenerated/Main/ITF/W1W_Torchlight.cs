namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Torchlight : ActorComponent {
		public bool bool__0;
		public Path Path__1;
		public Vec3d Vector3__2;
		public Vec2d Vector2__3;
		public Angle Angle__4;
		public Path Path__5;
		public Vec3d Vector3__6;
		public Vec2d Vector2__7;
		public Angle Angle__8;
		public Path Path__9;
		public Vec3d Vector3__10;
		public Vec2d Vector2__11;
		public Angle Angle__12;
		public bool bool__13;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			Path__1 = s.SerializeObject<Path>(Path__1, name: "Path__1");
			Vector3__2 = s.SerializeObject<Vec3d>(Vector3__2, name: "Vector3__2");
			Vector2__3 = s.SerializeObject<Vec2d>(Vector2__3, name: "Vector2__3");
			Angle__4 = s.SerializeObject<Angle>(Angle__4, name: "Angle__4");
			Path__5 = s.SerializeObject<Path>(Path__5, name: "Path__5");
			Vector3__6 = s.SerializeObject<Vec3d>(Vector3__6, name: "Vector3__6");
			Vector2__7 = s.SerializeObject<Vec2d>(Vector2__7, name: "Vector2__7");
			Angle__8 = s.SerializeObject<Angle>(Angle__8, name: "Angle__8");
			Path__9 = s.SerializeObject<Path>(Path__9, name: "Path__9");
			Vector3__10 = s.SerializeObject<Vec3d>(Vector3__10, name: "Vector3__10");
			Vector2__11 = s.SerializeObject<Vec2d>(Vector2__11, name: "Vector2__11");
			Angle__12 = s.SerializeObject<Angle>(Angle__12, name: "Angle__12");
			bool__13 = s.Serialize<bool>(bool__13, name: "bool__13");
		}
		public override uint? ClassCRC => 0xFFDA9322;
	}
}

