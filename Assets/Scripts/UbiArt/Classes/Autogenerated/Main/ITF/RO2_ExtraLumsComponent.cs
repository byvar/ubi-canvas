using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ExtraLumsComponent : ActorComponent {
		public float disappearStartTime;
		public float disappearIntervalTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				disappearStartTime = s.Serialize<float>(disappearStartTime, name: "disappearStartTime");
				disappearIntervalTime = s.Serialize<float>(disappearIntervalTime, name: "disappearIntervalTime");
			}
		}
		public override uint? ClassCRC => 0x8A1EAD12;
	}
}

