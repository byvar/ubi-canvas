using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class WwiseActivatorComponent : ActorComponent {
		[Serialize("StringID__0"      )] public StringID StringID__0;
		[Serialize("Generic<Event>__1")] public Generic<Event> Generic_Event__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(Generic_Event__1));
		}
		public override uint? ClassCRC => 0x62C064FE;
	}
}

