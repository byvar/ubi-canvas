using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTDelay : BTNode {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8C60A622;
	}
}

