using UnityEngine;

namespace UbiArt.ITF {
	public partial class DialogComponent : DialogBaseComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x179AE799;
	}
}

