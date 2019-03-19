using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ThrowableObject_Template : W1W_InteractiveGenComponent_Template {
		[Serialize("float__0")] public float float__0;
		[Serialize("float__1")] public float float__1;
		[Serialize("float__2")] public float float__2;
		[Serialize("float__3")] public float float__3;
		[Serialize("float__4")] public float float__4;
		[Serialize("float__5")] public float float__5;
		[Serialize("float__6")] public float float__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(float__6));
		}
		public override uint? ClassCRC => 0x61C3CA24;
	}
}

