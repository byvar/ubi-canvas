using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventBTJumpToPos : RO2_EventJumpToPos {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7AFA48A4;
	}
}

