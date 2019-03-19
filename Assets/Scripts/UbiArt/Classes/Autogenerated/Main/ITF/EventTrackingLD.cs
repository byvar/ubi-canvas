using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class EventTrackingLD : Event {
		[Serialize("description")] public string description;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(description));
		}
		public override uint? ClassCRC => 0x4CF17E07;
	}
}

