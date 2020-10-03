using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class WwiseActivatorComponent : ActorComponent {
		public StringID StringID__0;
		public Generic<Event> Generic_Event__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			Generic_Event__1 = s.SerializeObject<Generic<Event>>(Generic_Event__1, name: "Generic<Event>__1");
		}
		public override uint? ClassCRC => 0x62C064FE;
	}
}

