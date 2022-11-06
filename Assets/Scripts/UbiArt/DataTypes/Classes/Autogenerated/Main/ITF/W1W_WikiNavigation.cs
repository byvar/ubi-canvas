using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_WikiNavigation : ActorComponent {
		public Path Path__0;
		public Path Path__1;
		public Path Path__2;
		public Path Path__3;
		public Path Path__4;
		public Path Path__5;
		public Vec2d Vector2__6;
		public Vec2d Vector2__7;
		public float float__8;
		public Vec2d Vector2__9;
		public Path Path__10;
		public uint uint__11;
		public uint uint__12;
		public Path Path__13;
		public Vec2d Vector2__14;
		public Vec2d Vector2__15;
		public Vec2d Vector2__16;
		public Vec2d Vector2__17;
		public Vec2d Vector2__18;
		public uint uint__19;
		public uint uint__20;
		public Vec2d Vector2__21;
		public Path Path__22;
		public Path Path__23;
		public Vec2d Vector2__24;
		public float float__25;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
			Path__1 = s.SerializeObject<Path>(Path__1, name: "Path__1");
			Path__2 = s.SerializeObject<Path>(Path__2, name: "Path__2");
			Path__3 = s.SerializeObject<Path>(Path__3, name: "Path__3");
			Path__4 = s.SerializeObject<Path>(Path__4, name: "Path__4");
			Path__5 = s.SerializeObject<Path>(Path__5, name: "Path__5");
			Vector2__6 = s.SerializeObject<Vec2d>(Vector2__6, name: "Vector2__6");
			Vector2__7 = s.SerializeObject<Vec2d>(Vector2__7, name: "Vector2__7");
			float__8 = s.Serialize<float>(float__8, name: "float__8");
			Vector2__9 = s.SerializeObject<Vec2d>(Vector2__9, name: "Vector2__9");
			Path__10 = s.SerializeObject<Path>(Path__10, name: "Path__10");
			uint__11 = s.Serialize<uint>(uint__11, name: "uint__11");
			uint__12 = s.Serialize<uint>(uint__12, name: "uint__12");
			Path__13 = s.SerializeObject<Path>(Path__13, name: "Path__13");
			Vector2__14 = s.SerializeObject<Vec2d>(Vector2__14, name: "Vector2__14");
			Vector2__15 = s.SerializeObject<Vec2d>(Vector2__15, name: "Vector2__15");
			Vector2__16 = s.SerializeObject<Vec2d>(Vector2__16, name: "Vector2__16");
			Vector2__17 = s.SerializeObject<Vec2d>(Vector2__17, name: "Vector2__17");
			Vector2__18 = s.SerializeObject<Vec2d>(Vector2__18, name: "Vector2__18");
			uint__19 = s.Serialize<uint>(uint__19, name: "uint__19");
			uint__20 = s.Serialize<uint>(uint__20, name: "uint__20");
			Vector2__21 = s.SerializeObject<Vec2d>(Vector2__21, name: "Vector2__21");
			Path__22 = s.SerializeObject<Path>(Path__22, name: "Path__22");
			Path__23 = s.SerializeObject<Path>(Path__23, name: "Path__23");
			Vector2__24 = s.SerializeObject<Vec2d>(Vector2__24, name: "Vector2__24");
			float__25 = s.Serialize<float>(float__25, name: "float__25");
		}
		public override uint? ClassCRC => 0x143B9E26;
	}
}

