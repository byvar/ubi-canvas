using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionFollowTarget_Template : BTActionWalkToTarget_Template {
		public float range;
		public StringID followTarget;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			range = s.Serialize<float>(range, name: "range");
			followTarget = s.SerializeObject<StringID>(followTarget, name: "followTarget");
		}
		public override uint? ClassCRC => 0x41F81535;
	}
}

