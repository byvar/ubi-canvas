using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_MachineGun : ActorComponent {
		[Serialize("bool__0"           )] public bool bool__0;
		[Serialize("float__1"          )] public float float__1;
		[Serialize("float__2"          )] public float float__2;
		[Serialize("Path__3"           )] public Path Path__3;
		[Serialize("Vector2__4"        )] public Vector2 Vector2__4;
		[Serialize("Vector2__5"        )] public Vector2 Vector2__5;
		[Serialize("StringID__6"       )] public StringID StringID__6;
		[Serialize("Generic<Event>__7" )] public Generic<Event> Generic_Event__7;
		[Serialize("Generic<Event>__8" )] public Generic<Event> Generic_Event__8;
		[Serialize("Generic<Event>__9" )] public Generic<Event> Generic_Event__9;
		[Serialize("Generic<Event>__10")] public Generic<Event> Generic_Event__10;
		[Serialize("EventSender__11"   )] public EventSender EventSender__11;
		[Serialize("EventSender__12"   )] public EventSender EventSender__12;
		[Serialize("bool__13"          )] public bool bool__13;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(Path__3));
			SerializeField(s, nameof(Vector2__4));
			SerializeField(s, nameof(Vector2__5));
			SerializeField(s, nameof(StringID__6));
			SerializeField(s, nameof(Generic_Event__7));
			SerializeField(s, nameof(Generic_Event__8));
			SerializeField(s, nameof(Generic_Event__9));
			SerializeField(s, nameof(Generic_Event__10));
			SerializeField(s, nameof(EventSender__11));
			SerializeField(s, nameof(EventSender__12));
			SerializeField(s, nameof(bool__13));
		}
		public override uint? ClassCRC => 0x71358457;
	}
}

