using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CornBTAIComponent : BTAIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD0310F30;
	}
}

