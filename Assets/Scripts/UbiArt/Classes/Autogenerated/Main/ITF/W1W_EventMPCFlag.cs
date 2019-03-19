using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventMPCFlag : Event {
		[Serialize("bool__0"    )] public bool bool__0;
		[Serialize("bool__1"    )] public bool bool__1;
		[Serialize("bool__2"    )] public bool bool__2;
		[Serialize("bool__3"    )] public bool bool__3;
		[Serialize("bool__4"    )] public bool bool__4;
		[Serialize("bool__5"    )] public bool bool__5;
		[Serialize("bool__6"    )] public bool bool__6;
		[Serialize("bool__7"    )] public bool bool__7;
		[Serialize("bool__8"    )] public bool bool__8;
		[Serialize("float__9"   )] public float float__9;
		[Serialize("bool__10"   )] public bool bool__10;
		[Serialize("bool__11"   )] public bool bool__11;
		[Serialize("bool__12"   )] public bool bool__12;
		[Serialize("bool__13"   )] public bool bool__13;
		[Serialize("Vector2__14")] public Vector2 Vector2__14;
		[Serialize("bool__15"   )] public bool bool__15;
		[Serialize("bool__16"   )] public bool bool__16;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(bool__1));
			SerializeField(s, nameof(bool__2));
			SerializeField(s, nameof(bool__3));
			SerializeField(s, nameof(bool__4));
			SerializeField(s, nameof(bool__5));
			SerializeField(s, nameof(bool__6));
			SerializeField(s, nameof(bool__7));
			SerializeField(s, nameof(bool__8));
			SerializeField(s, nameof(float__9));
			SerializeField(s, nameof(bool__10));
			SerializeField(s, nameof(bool__11));
			SerializeField(s, nameof(bool__12));
			SerializeField(s, nameof(bool__13));
			SerializeField(s, nameof(Vector2__14));
			SerializeField(s, nameof(bool__15));
			SerializeField(s, nameof(bool__16));
		}
		public override uint? ClassCRC => 0x726A38AB;
	}
}

