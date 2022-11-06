using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_TutoBubble_Template : ActorComponent_Template {
		public CArrayP<float> CArray_float__0;
		public CArrayP<float> CArray_float__1;
		public CArrayP<float> CArray_float__2;
		public CArrayP<float> CArray_float__3;
		public CArrayP<float> CArray_float__4;
		public CArrayP<float> CArray_float__5;
		public CArrayP<float> CArray_float__6;
		public CArrayP<float> CArray_float__7;
		public float float__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				CArray_float__0 = s.SerializeObject<CArrayP<float>>(CArray_float__0, name: "CArray<float>__0");
				CArray_float__1 = s.SerializeObject<CArrayP<float>>(CArray_float__1, name: "CArray<float>__1");
				CArray_float__2 = s.SerializeObject<CArrayP<float>>(CArray_float__2, name: "CArray<float>__2");
				CArray_float__3 = s.SerializeObject<CArrayP<float>>(CArray_float__3, name: "CArray<float>__3");
				CArray_float__4 = s.SerializeObject<CArrayP<float>>(CArray_float__4, name: "CArray<float>__4");
				CArray_float__5 = s.SerializeObject<CArrayP<float>>(CArray_float__5, name: "CArray<float>__5");
				CArray_float__6 = s.SerializeObject<CArrayP<float>>(CArray_float__6, name: "CArray<float>__6");
				CArray_float__7 = s.SerializeObject<CArrayP<float>>(CArray_float__7, name: "CArray<float>__7");
				float__8 = s.Serialize<float>(float__8, name: "float__8");
			}
		}
		public override uint? ClassCRC => 0xC9920A14;
	}
}

