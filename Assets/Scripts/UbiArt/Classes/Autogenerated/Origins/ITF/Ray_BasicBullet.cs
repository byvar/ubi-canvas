using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BasicBullet : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x014D5392;
	}
}

