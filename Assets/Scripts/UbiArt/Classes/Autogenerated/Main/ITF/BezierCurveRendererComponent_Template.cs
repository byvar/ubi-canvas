using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BezierCurveRendererComponent_Template : ActorComponent_Template {
		public BezierCurveRenderer_Template renderer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			renderer = s.SerializeObject<BezierCurveRenderer_Template>(renderer, name: "renderer");
		}
		public override uint? ClassCRC => 0x200436A6;
	}
}

