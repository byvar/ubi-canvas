using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class DOGController : ActorComponent {
		public float float__0;
		public float float__1;
		public float float__2;
		public float float__3;
		public Vec2d Vector2__4;
		public Vec2d Vector2__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public bool bool__9;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			Vector2__4 = s.SerializeObject<Vec2d>(Vector2__4, name: "Vector2__4");
			Vector2__5 = s.SerializeObject<Vec2d>(Vector2__5, name: "Vector2__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			float__8 = s.Serialize<float>(float__8, name: "float__8");
			bool__9 = s.Serialize<bool>(bool__9, name: "bool__9");
		}
		public override uint? ClassCRC => 0x1AC2A37A;
	}
}

