using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_TutoBubble_Template : ActorComponent_Template {
		public CArray<float> CArray_float__0;
		public CArray<float> CArray_float__1;
		public CArray<float> CArray_float__2;
		public CArray<float> CArray_float__3;
		public CArray<float> CArray_float__4;
		public CArray<float> CArray_float__5;
		public CArray<float> CArray_float__6;
		public CArray<float> CArray_float__7;
		public float float__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				CArray_float__0 = s.SerializeObject<CArray<float>>(CArray_float__0, name: "CArray_float__0");
				CArray_float__1 = s.SerializeObject<CArray<float>>(CArray_float__1, name: "CArray_float__1");
				CArray_float__2 = s.SerializeObject<CArray<float>>(CArray_float__2, name: "CArray_float__2");
				CArray_float__3 = s.SerializeObject<CArray<float>>(CArray_float__3, name: "CArray_float__3");
				CArray_float__4 = s.SerializeObject<CArray<float>>(CArray_float__4, name: "CArray_float__4");
				CArray_float__5 = s.SerializeObject<CArray<float>>(CArray_float__5, name: "CArray_float__5");
				CArray_float__6 = s.SerializeObject<CArray<float>>(CArray_float__6, name: "CArray_float__6");
				CArray_float__7 = s.SerializeObject<CArray<float>>(CArray_float__7, name: "CArray_float__7");
				float__8 = s.Serialize<float>(float__8, name: "float__8");
			}
		}
		public override uint? ClassCRC => 0xC9920A14;
	}
}

