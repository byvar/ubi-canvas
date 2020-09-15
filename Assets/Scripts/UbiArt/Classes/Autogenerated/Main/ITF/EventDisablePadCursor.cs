using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EventDisablePadCursor : Event {
		public bool Disabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Disabled = s.Serialize<bool>(Disabled, name: "Disabled");
		}
		public override uint? ClassCRC => 0x5B0A456D;
	}
}

