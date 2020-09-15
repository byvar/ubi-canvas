using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class DetectorComponent_Template : ActorComponent_Template {
		public bool resetOnCheckpoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			resetOnCheckpoint = s.Serialize<bool>(resetOnCheckpoint, name: "resetOnCheckpoint");
		}
		public override uint? ClassCRC => 0x83953116;
	}
}

