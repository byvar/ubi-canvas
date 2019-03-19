using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class AnemoneTreeComponent : ActorComponent {
		[Serialize("startOpen"  )] public bool startOpen;
		[Serialize("branchSpeed")] public float branchSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startOpen));
				SerializeField(s, nameof(branchSpeed));
			}
		}
		public override uint? ClassCRC => 0x4A952A11;
	}
}

