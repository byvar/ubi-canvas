using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class TextComponent_Template : CSerializable {
		public CString CString__0;
		public float float__1;
		public Color Color__2;
		public float float__3;
		public int int__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public CString CString__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			CString__0 = s.Serialize<CString>(CString__0, name: "CString__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			Color__2 = s.SerializeObject<Color>(Color__2, name: "Color__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			int__4 = s.Serialize<int>(int__4, name: "int__4");
			float__5 = s.Serialize<float>(float__5, name: "float__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			CString__8 = s.Serialize<CString>(CString__8, name: "CString__8");
		}
		public override uint? ClassCRC => 0xEA7645E7;
	}
}

