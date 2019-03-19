using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_FreeTeensyCounterComponent_Template : ActorComponent_Template {
		[Serialize("locID")] public LocalisationId locID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(locID));
		}
		public override uint? ClassCRC => 0x50A7CEC6;
	}
}

