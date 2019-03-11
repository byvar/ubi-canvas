using UnityEngine;

namespace UbiArt.ITF {
	public partial class WithAnimState : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD7CBD647;
	}
}

