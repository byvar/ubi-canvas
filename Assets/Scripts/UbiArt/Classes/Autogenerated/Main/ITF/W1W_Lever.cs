using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Lever : W1W_InteractiveGenComponent {
		public bool bool__0;
		public bool bool__1;
		public bool bool__2;
		public bool bool__3;
		public float float__4;
		public bool bool__5;
		public float float__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
				bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
				bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
				float__4 = s.Serialize<float>(float__4, name: "float__4");
				bool__5 = s.Serialize<bool>(bool__5, name: "bool__5");
				float__6 = s.Serialize<float>(float__6, name: "float__6");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			}
		}
		public override uint? ClassCRC => 0x86E8F84E;
	}
}

