using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventPlaySignFeedback : Event {
		public bool bool__0;
		public bool bool__1;
		public float float__2;
		public uint uint__3;
		public Vec2d Vector2__4;
		public StringID StringID__5;
		public float float__6;
		public float float__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
			Vector2__4 = s.SerializeObject<Vec2d>(Vector2__4, name: "Vector2__4");
			StringID__5 = s.SerializeObject<StringID>(StringID__5, name: "StringID__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
		}
		public override uint? ClassCRC => 0xDD2B4018;
	}
}

