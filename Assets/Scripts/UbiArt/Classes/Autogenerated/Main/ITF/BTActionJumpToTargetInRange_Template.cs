using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTActionJumpToTargetInRange_Template : BTActionJumpToTarget_Template {
		[Serialize("range")] public float range;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(range));
		}
		public override uint? ClassCRC => 0xA73AA28D;
	}
}

