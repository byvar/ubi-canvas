using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_CharDiaNavigation : ActorComponent {
		public Path Path__0;
		public Path Path__1;
		public Path Path__2;
		public Path Path__3;
		public Vec2d Vector2__4;
		public Vec2d Vector2__5;
		public float float__6;
		public Vec2d Vector2__7;
		public Path Path__8;
		public Path Path__9;
		public Path Path__10;
		public Path Path__11;
		public Path Path__12;
		public Vec2d Vector2__13;
		public Vec2d Vector2__14;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
			Path__1 = s.SerializeObject<Path>(Path__1, name: "Path__1");
			Path__2 = s.SerializeObject<Path>(Path__2, name: "Path__2");
			Path__3 = s.SerializeObject<Path>(Path__3, name: "Path__3");
			Vector2__4 = s.SerializeObject<Vec2d>(Vector2__4, name: "Vector2__4");
			Vector2__5 = s.SerializeObject<Vec2d>(Vector2__5, name: "Vector2__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			Vector2__7 = s.SerializeObject<Vec2d>(Vector2__7, name: "Vector2__7");
			Path__8 = s.SerializeObject<Path>(Path__8, name: "Path__8");
			Path__9 = s.SerializeObject<Path>(Path__9, name: "Path__9");
			Path__10 = s.SerializeObject<Path>(Path__10, name: "Path__10");
			Path__11 = s.SerializeObject<Path>(Path__11, name: "Path__11");
			Path__12 = s.SerializeObject<Path>(Path__12, name: "Path__12");
			Vector2__13 = s.SerializeObject<Vec2d>(Vector2__13, name: "Vector2__13");
			Vector2__14 = s.SerializeObject<Vec2d>(Vector2__14, name: "Vector2__14");
		}
		public override uint? ClassCRC => 0xD45EB3E3;
	}
}

