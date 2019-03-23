using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class DeathDetectorComponent_Template : DetectorComponent_Template {
		[Serialize("isAnd"            )] public bool isAnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isAnd));
		}
		public override uint? ClassCRC => 0x40206760;
	}
}

