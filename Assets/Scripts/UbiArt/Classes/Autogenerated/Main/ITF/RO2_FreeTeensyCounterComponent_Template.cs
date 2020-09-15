using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_FreeTeensyCounterComponent_Template : ActorComponent_Template {
		public LocalisationId locID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			locID = s.SerializeObject<LocalisationId>(locID, name: "locID");
		}
		public override uint? ClassCRC => 0x50A7CEC6;
	}
}

