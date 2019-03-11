using UnityEngine;

namespace UbiArt.ITF {
	public partial class RenderBezierPatchCurveComponent_Template : CSerializable {
		[Serialize("bezierRenderer")] public Placeholder bezierRenderer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bezierRenderer));
		}
		public override uint? ClassCRC => 0x7C8C6C33;
	}
}

