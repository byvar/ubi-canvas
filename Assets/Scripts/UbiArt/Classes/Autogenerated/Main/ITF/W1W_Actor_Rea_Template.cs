using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Actor_Rea_Template : ActorComponent_Template {
		public StringID StringID__0;
		public float float__1;
		public Vec2d Vector2__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			Vector2__2 = s.SerializeObject<Vec2d>(Vector2__2, name: "Vector2__2");
		}
		public override uint? ClassCRC => 0x6F0AFE93;
	}
}

