using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTAction : BTNode {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2C6372C3;
	}
}

