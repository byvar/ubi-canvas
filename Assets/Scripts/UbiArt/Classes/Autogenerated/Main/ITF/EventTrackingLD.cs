using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventTrackingLD : Event {
		public string description;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			description = s.Serialize<string>(description, name: "description");
		}
		public override uint? ClassCRC => 0x4CF17E07;
	}
}

