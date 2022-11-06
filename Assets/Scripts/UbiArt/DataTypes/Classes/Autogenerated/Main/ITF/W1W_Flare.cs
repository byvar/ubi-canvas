using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Flare : ActorComponent {
		public Vec2d Vector2__0;
		public float float__1;
		public float float__2;
		public float float__3;
		public Vec2d Vector2__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public Generic<Event> Generic_Event__9;
		public Generic<Event> Generic_Event__10;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Vector2__0 = s.SerializeObject<Vec2d>(Vector2__0, name: "Vector2__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			Vector2__4 = s.SerializeObject<Vec2d>(Vector2__4, name: "Vector2__4");
			float__5 = s.Serialize<float>(float__5, name: "float__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			float__8 = s.Serialize<float>(float__8, name: "float__8");
			Generic_Event__9 = s.SerializeObject<Generic<Event>>(Generic_Event__9, name: "Generic<Event>__9");
			Generic_Event__10 = s.SerializeObject<Generic<Event>>(Generic_Event__10, name: "Generic<Event>__10");
		}
		public override uint? ClassCRC => 0x110A85EE;
	}
}

