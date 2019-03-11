using UnityEngine;

namespace UbiArt.ITF {
	public partial class StartCapture_evt : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA23C57DD;
	}
}

