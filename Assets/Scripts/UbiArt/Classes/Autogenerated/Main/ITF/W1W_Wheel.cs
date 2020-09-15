using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Wheel : W1W_InteractiveGenComponent {
		public bool bool__0;
		public bool bool__1;
		public bool bool__2;
		public bool bool__3;
		public bool bool__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public float float__9;
		public uint uint__10;
		public float float__11_;
		public bool bool__12;
		public float float__13_;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
				bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
				bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
				bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
				bool__4 = s.Serialize<bool>(bool__4, name: "bool__4");
				float__5 = s.Serialize<float>(float__5, name: "float__5");
				float__6 = s.Serialize<float>(float__6, name: "float__6");
				float__7 = s.Serialize<float>(float__7, name: "float__7");
				float__8 = s.Serialize<float>(float__8, name: "float__8");
				float__9 = s.Serialize<float>(float__9, name: "float__9");
				uint__10 = s.Serialize<uint>(uint__10, name: "uint__10");
				float__11_ = s.Serialize<float>(float__11_, name: "float__11_");
				bool__12 = s.Serialize<bool>(bool__12, name: "bool__12");
				float__13_ = s.Serialize<float>(float__13_, name: "float__13_");
			}
		}
		public override uint? ClassCRC => 0x9B0058FF;
	}
}

