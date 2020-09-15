using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventLaunchCredits : Event {
		public bool onlyPrefetch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			onlyPrefetch = s.Serialize<bool>(onlyPrefetch, name: "onlyPrefetch");
		}
		public override uint? ClassCRC => 0x376C63C3;
	}
}

