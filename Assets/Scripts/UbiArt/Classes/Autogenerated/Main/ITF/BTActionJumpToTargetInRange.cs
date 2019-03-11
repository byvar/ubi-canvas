using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTActionJumpToTargetInRange : BTActionJumpToTarget {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x64A17E7D;
	}
}

