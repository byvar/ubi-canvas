using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Gadgets : CSerializable {
		public int int__0;
		public int int__1;
		public int int__2;
		public int int__3;
		public int int__4;
		public int int__5;
		public int int__6;
		public int int__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			int__0 = s.Serialize<int>(int__0, name: "int__0");
			int__1 = s.Serialize<int>(int__1, name: "int__1");
			int__2 = s.Serialize<int>(int__2, name: "int__2");
			int__3 = s.Serialize<int>(int__3, name: "int__3");
			int__4 = s.Serialize<int>(int__4, name: "int__4");
			int__5 = s.Serialize<int>(int__5, name: "int__5");
			int__6 = s.Serialize<int>(int__6, name: "int__6");
			int__7 = s.Serialize<int>(int__7, name: "int__7");
		}
	}
}

