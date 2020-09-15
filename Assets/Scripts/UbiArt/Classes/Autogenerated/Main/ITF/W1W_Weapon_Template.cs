using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Weapon_Template : W1W_InteractiveGenComponent_Template {
		public float float__0;
		public Vec2d Vector2__1;
		public StringID StringID__2;
		public StringID StringID__3;
		public StringID StringID__4;
		public StringID StringID__5;
		public StringID StringID__6;
		public StringID StringID__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			Vector2__1 = s.SerializeObject<Vec2d>(Vector2__1, name: "Vector2__1");
			StringID__2 = s.SerializeObject<StringID>(StringID__2, name: "StringID__2");
			StringID__3 = s.SerializeObject<StringID>(StringID__3, name: "StringID__3");
			StringID__4 = s.SerializeObject<StringID>(StringID__4, name: "StringID__4");
			StringID__5 = s.SerializeObject<StringID>(StringID__5, name: "StringID__5");
			StringID__6 = s.SerializeObject<StringID>(StringID__6, name: "StringID__6");
			StringID__7 = s.SerializeObject<StringID>(StringID__7, name: "StringID__7");
		}
		public override uint? ClassCRC => 0x851414A2;
	}
}

