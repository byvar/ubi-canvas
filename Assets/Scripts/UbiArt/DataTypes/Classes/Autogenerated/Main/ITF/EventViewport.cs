using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventViewport : Event {
		public bool activated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activated = s.Serialize<bool>(activated, name: "activated");
		}
		public override uint? ClassCRC => 0x8386BA64;
	}
}

