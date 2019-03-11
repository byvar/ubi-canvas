using UnityEngine;

namespace UbiArt.ITF {
	public partial class ObjectControllerComponent : LinkComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x44D9B5B0;
	}
}

