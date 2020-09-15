using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventDigEnable : Event {
		public bool enable;
		public float radius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enable = s.Serialize<bool>(enable, name: "enable");
			radius = s.Serialize<float>(radius, name: "radius");
		}
		public override uint? ClassCRC => 0x41B70F26;
	}
}

