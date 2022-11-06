using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_TouchSwiperComponent_Template : ActorComponent_Template {
		public string string__0;
		public float float__1;
		public float float__2;
		public float float__3;
		public float float__4;
		public float float__5;
		public float float__6;
		public bool bool__7;
		public uint uint__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			string__0 = s.Serialize<string>(string__0, name: "string__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			float__4 = s.Serialize<float>(float__4, name: "float__4");
			float__5 = s.Serialize<float>(float__5, name: "float__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			bool__7 = s.Serialize<bool>(bool__7, name: "bool__7");
			uint__8 = s.Serialize<uint>(uint__8, name: "uint__8");
		}
		public override uint? ClassCRC => 0xEC74512F;
	}
}

