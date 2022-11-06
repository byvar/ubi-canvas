using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TeleportWithAnimationComponent : ActorComponent {
		public float TeleportDuration;
		public float TeleportMouthOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			TeleportDuration = s.Serialize<float>(TeleportDuration, name: "TeleportDuration");
			TeleportMouthOffset = s.Serialize<float>(TeleportMouthOffset, name: "TeleportMouthOffset");
		}
		public override uint? ClassCRC => 0x225888F1;
	}
}

