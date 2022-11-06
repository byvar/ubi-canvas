using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_ExampleComponent : ActorComponent {
		public float someValue;
		public Generic<Event> someEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				someValue = s.Serialize<float>(someValue, name: "someValue");
				someEvent = s.SerializeObject<Generic<Event>>(someEvent, name: "someEvent");
			}
		}
		public override uint? ClassCRC => 0x8641F7FA;
	}
}

