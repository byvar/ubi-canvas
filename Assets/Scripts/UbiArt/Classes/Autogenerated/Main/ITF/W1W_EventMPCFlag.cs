using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventMPCFlag : Event {
		public bool bool__0;
		public bool bool__1;
		public bool bool__2;
		public bool bool__3;
		public bool bool__4;
		public bool bool__5;
		public bool bool__6;
		public bool bool__7;
		public bool bool__8;
		public float float__9;
		public bool bool__10;
		public bool bool__11;
		public bool bool__12;
		public bool bool__13;
		public Vec2d Vector2__14;
		public bool bool__15;
		public bool bool__16;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
			bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
			bool__4 = s.Serialize<bool>(bool__4, name: "bool__4");
			bool__5 = s.Serialize<bool>(bool__5, name: "bool__5");
			bool__6 = s.Serialize<bool>(bool__6, name: "bool__6");
			bool__7 = s.Serialize<bool>(bool__7, name: "bool__7");
			bool__8 = s.Serialize<bool>(bool__8, name: "bool__8");
			float__9 = s.Serialize<float>(float__9, name: "float__9");
			bool__10 = s.Serialize<bool>(bool__10, name: "bool__10");
			bool__11 = s.Serialize<bool>(bool__11, name: "bool__11");
			bool__12 = s.Serialize<bool>(bool__12, name: "bool__12");
			bool__13 = s.Serialize<bool>(bool__13, name: "bool__13");
			Vector2__14 = s.SerializeObject<Vec2d>(Vector2__14, name: "Vector2__14");
			bool__15 = s.Serialize<bool>(bool__15, name: "bool__15");
			bool__16 = s.Serialize<bool>(bool__16, name: "bool__16");
		}
		public override uint? ClassCRC => 0x726A38AB;
	}
}

