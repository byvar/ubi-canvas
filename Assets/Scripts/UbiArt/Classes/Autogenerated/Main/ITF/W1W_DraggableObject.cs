using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_DraggableObject : W1W_InteractiveGenComponent {
		public Vec2d Vector2__0;
		public bool bool__1;
		public bool bool__2;
		public bool bool__3;
		public float float__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public StringID StringID__9;
		public StringID StringID__10;
		public float float__11_;
		public EventSender EventSender__12;
		public EventSender EventSender__13;
		public EventSender EventSender__14;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
			bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
			float__4 = s.Serialize<float>(float__4, name: "float__4");
			float__5 = s.Serialize<float>(float__5, name: "float__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			float__8 = s.Serialize<float>(float__8, name: "float__8");
			StringID__9 = s.SerializeObject<StringID>(StringID__9, name: "StringID__9");
			StringID__10 = s.SerializeObject<StringID>(StringID__10, name: "StringID__10");
			float__11_ = s.Serialize<float>(float__11_, name: "float__11_");
			EventSender__12 = s.SerializeObject<EventSender>(EventSender__12, name: "EventSender__12");
			EventSender__13 = s.SerializeObject<EventSender>(EventSender__13, name: "EventSender__13");
			EventSender__14 = s.SerializeObject<EventSender>(EventSender__14, name: "EventSender__14");
			if (s.HasFlags(SerializeFlags.Persistent)) {
				Vector2__0 = s.SerializeObject<Vec2d>(Vector2__0, name: "Vector2__0");
				bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
			}
		}
		public override uint? ClassCRC => 0x4A0E2857;
	}
}

