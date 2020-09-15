using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EventNoHit : Event {
		public bool activateNoHit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activateNoHit = s.Serialize<bool>(activateNoHit, name: "activateNoHit");
		}
		public override uint? ClassCRC => 0x727932AF;
	}
}

