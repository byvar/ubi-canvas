using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TeleportWithAnimationComponent : ActorComponent {
		[Serialize("TeleportDuration"   )] public float TeleportDuration;
		[Serialize("TeleportMouthOffset")] public float TeleportMouthOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(TeleportDuration));
			SerializeField(s, nameof(TeleportMouthOffset));
		}
		public override uint? ClassCRC => 0x225888F1;
	}
}

