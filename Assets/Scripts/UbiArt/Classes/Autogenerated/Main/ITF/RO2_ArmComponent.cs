using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ArmComponent : ActorComponent {
		public uint activationState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				activationState = s.Serialize<uint>(activationState, name: "activationState");
			}
		}
		public override uint? ClassCRC => 0x50767C54;
	}
}

