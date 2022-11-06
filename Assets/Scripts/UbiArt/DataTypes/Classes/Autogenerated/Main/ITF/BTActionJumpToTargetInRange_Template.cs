using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class BTActionJumpToTargetInRange_Template : BTActionJumpToTarget_Template {
		public float range;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			range = s.Serialize<float>(range, name: "range");
		}
		public override uint? ClassCRC => 0xA73AA28D;
	}
}

