using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_DraggableObject : W1W_InteractiveGenComponent {
		[Serialize("Vector2__0"     )] public Vector2 Vector2__0;
		[Serialize("bool__1"        )] public bool bool__1;
		[Serialize("bool__2"        )] public bool bool__2;
		[Serialize("bool__3"        )] public bool bool__3;
		[Serialize("float__4"       )] public float float__4;
		[Serialize("float__5"       )] public float float__5;
		[Serialize("float__6"       )] public float float__6;
		[Serialize("float__7"       )] public float float__7;
		[Serialize("float__8"       )] public float float__8;
		[Serialize("StringID__9"    )] public StringID StringID__9;
		[Serialize("StringID__10"   )] public StringID StringID__10;
		[Serialize("float__11"      )] public float float__11_;
		[Serialize("EventSender__12")] public EventSender EventSender__12;
		[Serialize("EventSender__13")] public EventSender EventSender__13;
		[Serialize("EventSender__14")] public EventSender EventSender__14;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__2));
			SerializeField(s, nameof(bool__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(float__7));
			SerializeField(s, nameof(float__8));
			SerializeField(s, nameof(StringID__9));
			SerializeField(s, nameof(StringID__10));
			SerializeField(s, nameof(float__11_));
			SerializeField(s, nameof(EventSender__12));
			SerializeField(s, nameof(EventSender__13));
			SerializeField(s, nameof(EventSender__14));
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(Vector2__0));
				SerializeField(s, nameof(bool__1));
			}
		}
		public override uint? ClassCRC => 0x4A0E2857;
	}
}

