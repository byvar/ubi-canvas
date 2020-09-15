using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PrisonerPostComponent : RO2_AIComponent {
		public bool isBroken;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				isBroken = s.Serialize<bool>(isBroken, name: "isBroken");
			}
		}
		public override uint? ClassCRC => 0x8401614A;
	}
}

