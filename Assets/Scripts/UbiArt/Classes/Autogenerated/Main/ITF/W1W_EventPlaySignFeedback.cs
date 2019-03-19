using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventPlaySignFeedback : Event {
		[Serialize("bool__0"    )] public bool bool__0;
		[Serialize("bool__1"    )] public bool bool__1;
		[Serialize("float__2"   )] public float float__2;
		[Serialize("uint__3"    )] public uint uint__3;
		[Serialize("Vector2__4" )] public Vector2 Vector2__4;
		[Serialize("StringID__5")] public StringID StringID__5;
		[Serialize("float__6"   )] public float float__6;
		[Serialize("float__7"   )] public float float__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(bool__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(uint__3));
			SerializeField(s, nameof(Vector2__4));
			SerializeField(s, nameof(StringID__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(float__7));
		}
		public override uint? ClassCRC => 0xDD2B4018;
	}
}

