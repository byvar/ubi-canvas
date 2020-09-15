using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventAutomaticPlayerMode : Event {
		public bool active;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			active = s.Serialize<bool>(active, name: "active");
		}
		public override uint? ClassCRC => 0xF96AE5FF;
	}
}

