using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTAIComponent : BTAIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6D2F7715;
	}
}

