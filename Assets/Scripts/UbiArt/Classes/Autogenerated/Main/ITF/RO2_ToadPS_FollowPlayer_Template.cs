using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ToadPS_FollowPlayer_Template : ActorPlugStateImplement_Template {
		[Serialize("keepSpeedDuration")] public float keepSpeedDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(keepSpeedDuration));
		}
		public override uint? ClassCRC => 0xF4EFAC12;
	}
}

