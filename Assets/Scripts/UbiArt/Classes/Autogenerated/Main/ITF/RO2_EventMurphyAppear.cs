using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventMurphyAppear : RO2_EventMurphy {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x012F0641;
	}
}

