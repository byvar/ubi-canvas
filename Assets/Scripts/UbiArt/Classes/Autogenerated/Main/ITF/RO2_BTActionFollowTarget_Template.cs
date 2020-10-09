using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionFollowTarget_Template : BTActionWalkToTarget_Template {
		public float range;
		public StringID followTarget;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			range = s.Serialize<float>(range, name: "range");
			followTarget = s.SerializeObject<StringID>(followTarget, name: "followTarget");
		}
		public override uint? ClassCRC => 0xF2AB7917;
	}
}

