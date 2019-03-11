using UnityEngine;

namespace UbiArt.ITF {
	public partial class DestructibleBodyPart : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x04D77336;
	}
}

