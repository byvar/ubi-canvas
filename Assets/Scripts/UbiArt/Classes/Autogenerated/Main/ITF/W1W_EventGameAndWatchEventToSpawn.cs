using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventGameAndWatchEventToSpawn : Event {
		public StringID StringID__0;
		public bool bool__1;
		public float float__2;
		public float float__3;
		public Generic<Event> Generic_Event__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			Generic_Event__4 = s.SerializeObject<Generic<Event>>(Generic_Event__4, name: "Generic_Event__4");
		}
		public override uint? ClassCRC => 0xEB02BD59;
	}
}

