using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AIDestroyAction_Template : AIAction_Template {
		[Serialize("waitForFx")] public bool waitForFx;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(waitForFx));
		}
		public override uint? ClassCRC => 0x70126893;
	}
}

