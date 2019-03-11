using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTTimer : BTNode {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x50548DFA;
	}
}

