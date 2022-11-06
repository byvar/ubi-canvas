using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_Magnet_Template : Ray_PowerUpDisplay_Template {
		public Path Path__0;
		public StringID StringID__1;
		public Vec2d Vector2__2;
		public float float__3;
		public float float__4;
		public float float__5;
		public float float__6;
		public float float__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			Vector2__2 = s.SerializeObject<Vec2d>(Vector2__2, name: "Vector2__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			float__4 = s.Serialize<float>(float__4, name: "float__4");
			float__5 = s.Serialize<float>(float__5, name: "float__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
		}
		public override uint? ClassCRC => 0xC6548A0A;
	}
}

