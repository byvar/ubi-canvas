using UnityEngine;

namespace UbiArt.ITF {
	public partial class Texture : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE54BF2CB;
	}
}

