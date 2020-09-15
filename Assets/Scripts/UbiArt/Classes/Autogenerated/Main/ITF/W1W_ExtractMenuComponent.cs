using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ExtractMenuComponent : ActorComponent {
		public Generic<Event> Generic_Event__0;
		public Generic<Event> Generic_Event__1;
		public Generic<Event> Generic_Event__2;
		public Generic<Event> Generic_Event__3;
		public Generic<Event> Generic_Event__4;
		public Generic<Event> Generic_Event__5;
		public Generic<Event> Generic_Event__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Generic_Event__0 = s.SerializeObject<Generic<Event>>(Generic_Event__0, name: "Generic_Event__0");
			Generic_Event__1 = s.SerializeObject<Generic<Event>>(Generic_Event__1, name: "Generic_Event__1");
			Generic_Event__2 = s.SerializeObject<Generic<Event>>(Generic_Event__2, name: "Generic_Event__2");
			Generic_Event__3 = s.SerializeObject<Generic<Event>>(Generic_Event__3, name: "Generic_Event__3");
			Generic_Event__4 = s.SerializeObject<Generic<Event>>(Generic_Event__4, name: "Generic_Event__4");
			Generic_Event__5 = s.SerializeObject<Generic<Event>>(Generic_Event__5, name: "Generic_Event__5");
			Generic_Event__6 = s.SerializeObject<Generic<Event>>(Generic_Event__6, name: "Generic_Event__6");
		}
		public override uint? ClassCRC => 0x6445CE07;
	}
}

