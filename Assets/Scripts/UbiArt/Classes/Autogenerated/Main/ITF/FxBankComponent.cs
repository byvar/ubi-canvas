using UnityEngine;

namespace UbiArt.ITF {
	public partial class FxBankComponent : GraphicComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x966B519D;
	}
}

