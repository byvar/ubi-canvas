using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.ROVersion | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayerDetectorComponent : ShapeDetectorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x28C01093;
	}
}

