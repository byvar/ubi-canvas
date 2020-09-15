using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AIDestroyAction_Template : AIAction_Template {
		public bool waitForFx;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waitForFx = s.Serialize<bool>(waitForFx, name: "waitForFx");
		}
		public override uint? ClassCRC => 0x70126893;
	}
}

