using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_ExampleComponent : ActorComponent {
		[Serialize("someValue")] public float someValue;
		[Serialize("someEvent")] public Generic<Event> someEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(someValue));
				SerializeField(s, nameof(someEvent));
			}
		}
		public override uint? ClassCRC => 0x8641F7FA;
	}
}

