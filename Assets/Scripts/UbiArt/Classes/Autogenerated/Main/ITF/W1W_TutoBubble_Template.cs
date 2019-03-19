using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_TutoBubble_Template : ActorComponent_Template {
		[Serialize("CArray<float>__0")] public CArray<float> CArray_float__0;
		[Serialize("CArray<float>__1")] public CArray<float> CArray_float__1;
		[Serialize("CArray<float>__2")] public CArray<float> CArray_float__2;
		[Serialize("CArray<float>__3")] public CArray<float> CArray_float__3;
		[Serialize("CArray<float>__4")] public CArray<float> CArray_float__4;
		[Serialize("CArray<float>__5")] public CArray<float> CArray_float__5;
		[Serialize("CArray<float>__6")] public CArray<float> CArray_float__6;
		[Serialize("CArray<float>__7")] public CArray<float> CArray_float__7;
		[Serialize("float__8"        )] public float float__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(CArray_float__0));
				SerializeField(s, nameof(CArray_float__1));
				SerializeField(s, nameof(CArray_float__2));
				SerializeField(s, nameof(CArray_float__3));
				SerializeField(s, nameof(CArray_float__4));
				SerializeField(s, nameof(CArray_float__5));
				SerializeField(s, nameof(CArray_float__6));
				SerializeField(s, nameof(CArray_float__7));
				SerializeField(s, nameof(float__8));
			}
		}
		public override uint? ClassCRC => 0xC9920A14;
	}
}

