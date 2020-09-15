using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AIJumpToTargetAction_Template : AIAction_Template {
		public float duration;
		public float height0;
		public float heught1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			duration = s.Serialize<float>(duration, name: "duration");
			height0 = s.Serialize<float>(height0, name: "height0");
			heught1 = s.Serialize<float>(heught1, name: "heught1");
		}
		public override uint? ClassCRC => 0xBCB521D7;
	}
}

