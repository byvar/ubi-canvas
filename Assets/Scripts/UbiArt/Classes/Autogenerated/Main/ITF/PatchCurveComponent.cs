using UnityEngine;

namespace UbiArt.ITF {
	public partial class PatchCurveComponent : GraphicComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE3FA6A0D;
	}
}

