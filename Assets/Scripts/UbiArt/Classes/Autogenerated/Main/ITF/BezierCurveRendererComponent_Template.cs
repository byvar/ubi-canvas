using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierCurveRendererComponent_Template : ActorComponent_Template {
		[Serialize("renderer")] public BezierCurveRenderer_Template renderer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(renderer));
		}
		public override uint? ClassCRC => 0x200436A6;
	}
}

