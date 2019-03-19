using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ArmComponent : ActorComponent {
		[Serialize("activationState")] public uint activationState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(activationState));
			}
		}
		public override uint? ClassCRC => 0x50767C54;
	}
}

