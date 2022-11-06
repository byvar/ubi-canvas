using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class RenderBezierPatchCurveComponent_Template : CSerializable {
		public Placeholder bezierRenderer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bezierRenderer = s.SerializeObject<Placeholder>(bezierRenderer, name: "bezierRenderer");
		}
		public override uint? ClassCRC => 0x7C8C6C33;
	}
}

