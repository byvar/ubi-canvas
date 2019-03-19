using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_TouchSwiperComponent_Template : ActorComponent_Template {
		[Serialize("string__0")] public string string__0;
		[Serialize("float__1" )] public float float__1;
		[Serialize("float__2" )] public float float__2;
		[Serialize("float__3" )] public float float__3;
		[Serialize("float__4" )] public float float__4;
		[Serialize("float__5" )] public float float__5;
		[Serialize("float__6" )] public float float__6;
		[Serialize("bool__7"  )] public bool bool__7;
		[Serialize("uint__8"  )] public uint uint__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(string__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(bool__7));
			SerializeField(s, nameof(uint__8));
		}
		public override uint? ClassCRC => 0xEC74512F;
	}
}

