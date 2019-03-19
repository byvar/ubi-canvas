using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Flare : ActorComponent {
		[Serialize("Vector2__0"        )] public Vector2 Vector2__0;
		[Serialize("float__1"          )] public float float__1;
		[Serialize("float__2"          )] public float float__2;
		[Serialize("float__3"          )] public float float__3;
		[Serialize("Vector2__4"        )] public Vector2 Vector2__4;
		[Serialize("float__5"          )] public float float__5;
		[Serialize("float__6"          )] public float float__6;
		[Serialize("float__7"          )] public float float__7;
		[Serialize("float__8"          )] public float float__8;
		[Serialize("Generic<Event>__9" )] public Generic<Event> Generic_Event__9;
		[Serialize("Generic<Event>__10")] public Generic<Event> Generic_Event__10;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Vector2__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(Vector2__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(float__7));
			SerializeField(s, nameof(float__8));
			SerializeField(s, nameof(Generic_Event__9));
			SerializeField(s, nameof(Generic_Event__10));
		}
		public override uint? ClassCRC => 0x110A85EE;
	}
}

