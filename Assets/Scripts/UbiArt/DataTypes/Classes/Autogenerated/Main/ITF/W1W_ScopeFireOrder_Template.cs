using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ScopeFireOrder_Template : ActorComponent_Template {
		public Vec2d Vector2__0;
		public float float__1;
		public float float__2;
		public float float__3;
		public float float__4;
		public float float__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Vector2__0 = s.SerializeObject<Vec2d>(Vector2__0, name: "Vector2__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			float__4 = s.Serialize<float>(float__4, name: "float__4");
			float__5 = s.Serialize<float>(float__5, name: "float__5");
		}
		public override uint? ClassCRC => 0xAE871D05;
	}
}

