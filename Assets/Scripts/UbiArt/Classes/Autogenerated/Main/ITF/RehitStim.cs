using UnityEngine;

namespace UbiArt.ITF {
	public partial class RehitStim : PunchStim {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3C1F6670;
	}
}

