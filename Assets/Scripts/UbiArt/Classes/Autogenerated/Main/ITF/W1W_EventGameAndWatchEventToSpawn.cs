using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventGameAndWatchEventToSpawn : Event {
		[Serialize("StringID__0"      )] public StringID StringID__0;
		[Serialize("bool__1"          )] public bool bool__1;
		[Serialize("float__2"         )] public float float__2;
		[Serialize("float__3"         )] public float float__3;
		[Serialize("Generic<Event>__4")] public Generic<Event> Generic_Event__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(bool__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(float__3));
			SerializeField(s, nameof(Generic_Event__4));
		}
		public override uint? ClassCRC => 0xEB02BD59;
	}
}

