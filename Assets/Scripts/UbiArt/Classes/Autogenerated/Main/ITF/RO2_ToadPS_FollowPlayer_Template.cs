using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ToadPS_FollowPlayer_Template : ActorPlugStateImplement_Template {
		public float keepSpeedDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			keepSpeedDuration = s.Serialize<float>(keepSpeedDuration, name: "keepSpeedDuration");
		}
		public override uint? ClassCRC => 0xF4EFAC12;
	}
}

