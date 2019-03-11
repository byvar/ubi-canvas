using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventMurphyDisappear : RO2_EventMurphy {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE82FE4E2;
	}
}

