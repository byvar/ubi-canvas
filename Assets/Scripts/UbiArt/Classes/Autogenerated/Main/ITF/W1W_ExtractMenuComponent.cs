using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ExtractMenuComponent : ActorComponent {
		[Serialize("Generic<Event>__0")] public Generic<Event> Generic_Event__0;
		[Serialize("Generic<Event>__1")] public Generic<Event> Generic_Event__1;
		[Serialize("Generic<Event>__2")] public Generic<Event> Generic_Event__2;
		[Serialize("Generic<Event>__3")] public Generic<Event> Generic_Event__3;
		[Serialize("Generic<Event>__4")] public Generic<Event> Generic_Event__4;
		[Serialize("Generic<Event>__5")] public Generic<Event> Generic_Event__5;
		[Serialize("Generic<Event>__6")] public Generic<Event> Generic_Event__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Generic_Event__0));
			SerializeField(s, nameof(Generic_Event__1));
			SerializeField(s, nameof(Generic_Event__2));
			SerializeField(s, nameof(Generic_Event__3));
			SerializeField(s, nameof(Generic_Event__4));
			SerializeField(s, nameof(Generic_Event__5));
			SerializeField(s, nameof(Generic_Event__6));
		}
		public override uint? ClassCRC => 0x6445CE07;
	}
}

