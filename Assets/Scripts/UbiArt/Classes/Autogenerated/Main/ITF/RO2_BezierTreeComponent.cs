using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_BezierTreeComponent : ActorComponent {
		[Serialize("branch")] public RO2_BezierBranch branch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(branch));
			}
		}
		public override uint? ClassCRC => 0x760B164E;
	}
}

