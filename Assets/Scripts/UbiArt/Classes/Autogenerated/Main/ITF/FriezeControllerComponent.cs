using UnityEngine;

namespace UbiArt.ITF {
	public partial class FriezeControllerComponent : LinkComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1B2951FD;
	}
}

