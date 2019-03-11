using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_PadDisplayControl : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x40511E04;
	}
}

