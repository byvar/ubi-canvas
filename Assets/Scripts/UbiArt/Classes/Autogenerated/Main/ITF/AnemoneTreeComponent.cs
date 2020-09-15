using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class AnemoneTreeComponent : ActorComponent {
		public bool startOpen;
		public float branchSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				startOpen = s.Serialize<bool>(startOpen, name: "startOpen");
				branchSpeed = s.Serialize<float>(branchSpeed, name: "branchSpeed");
			}
		}
		public override uint? ClassCRC => 0x4A952A11;
	}
}

