using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_AnemoneTreeComponent : ActorComponent {
		[Serialize("startOpen"  )] public bool startOpen;
		[Serialize("branchSpeed")] public float branchSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startOpen));
				SerializeField(s, nameof(branchSpeed));
			}
		}
		public override uint? ClassCRC => 0x084CC871;
	}
}

