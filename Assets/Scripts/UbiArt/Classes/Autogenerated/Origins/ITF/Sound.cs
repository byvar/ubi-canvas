using UnityEngine;

namespace UbiArt.ITF {
	public partial class Sound : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9B7EB41F;
	}
}

