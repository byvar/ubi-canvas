using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierTreeAmvComponent : GraphicComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB31E5142;
	}
}

