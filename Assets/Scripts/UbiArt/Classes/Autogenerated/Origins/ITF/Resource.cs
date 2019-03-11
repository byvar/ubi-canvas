using UnityEngine;

namespace UbiArt.ITF {
	public partial class Resource : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3205E118;
	}
}