using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class BezierTreeComponent : ActorComponent {
		[Serialize("branch")] public BezierBranch branch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(branch));
			}
		}
		public override uint? ClassCRC => 0x3236CF4C;
	}
}

