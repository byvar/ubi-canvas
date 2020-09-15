using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventAreaOfEffect : Event {
		public float float__0;
		public Enum_VH_0 Enum_VH_0__1;
		public Vec2d Vector2__2;
		public Vec2d Vector2__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			Enum_VH_0__1 = s.Serialize<Enum_VH_0>(Enum_VH_0__1, name: "Enum_VH_0__1");
			Vector2__2 = s.SerializeObject<Vec2d>(Vector2__2, name: "Vector2__2");
			Vector2__3 = s.SerializeObject<Vec2d>(Vector2__3, name: "Vector2__3");
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
		}
		public override uint? ClassCRC => 0xF6E63A46;
	}
}

