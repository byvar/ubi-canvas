using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_WatchAndDetect : ActorComponent {
		[Serialize("float__0"         )] public float float__0;
		[Serialize("float__1"         )] public float float__1;
		[Serialize("float__2"         )] public float float__2;
		[Serialize("float__3"         )] public float float__3;
		[Serialize("bool__4"          )] public bool bool__4;
		[Serialize("Generic<Event>__5")] public Generic<Event> Generic_Event__5;
		[Serialize("Generic<Event>__6")] public Generic<Event> Generic_Event__6;
		[Serialize("Generic<Event>__7")] public Generic<Event> Generic_Event__7;
		[Serialize("Generic<Event>__8")] public Generic<Event> Generic_Event__8;
		[Serialize("EventSender__9"   )] public EventSender EventSender__9;
		[Serialize("EventSender__10"  )] public EventSender EventSender__10;
		[Serialize("EventSender__11"  )] public EventSender EventSender__11;
		[Serialize("EventSender__12"  )] public EventSender EventSender__12;
		[Serialize("EventSender__13"  )] public EventSender EventSender__13;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(bool__4));
			SerializeField(s, nameof(Generic_Event__5));
			SerializeField(s, nameof(Generic_Event__6));
			SerializeField(s, nameof(Generic_Event__7));
			SerializeField(s, nameof(Generic_Event__8));
			SerializeField(s, nameof(EventSender__9));
			SerializeField(s, nameof(EventSender__10));
			SerializeField(s, nameof(EventSender__11));
			SerializeField(s, nameof(EventSender__12));
			SerializeField(s, nameof(EventSender__13));
		}
		public override uint? ClassCRC => 0xC139C1E6;
	}
}

