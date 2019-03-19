using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class DetectorComponent_Template : ActorComponent_Template {
		[Serialize("resetOnCheckpoint")] public bool resetOnCheckpoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(resetOnCheckpoint));
		}
		public override uint? ClassCRC => 0x83953116;
	}
}

