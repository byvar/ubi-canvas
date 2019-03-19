using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class TextComponent_Template : CSerializable {
		[Serialize("CString__0")] public CString CString__0;
		[Serialize("float__1"  )] public float float__1;
		[Serialize("Color__2"  )] public Color Color__2;
		[Serialize("float__3"  )] public float float__3;
		[Serialize("int__4"    )] public int int__4;
		[Serialize("float__5"  )] public float float__5;
		[Serialize("float__6"  )] public float float__6;
		[Serialize("float__7"  )] public float float__7;
		[Serialize("CString__8")] public CString CString__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CString__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(Color__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(int__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(float__7));
			SerializeField(s, nameof(CString__8));
		}
		public override uint? ClassCRC => 0xEA7645E7;
	}
}

