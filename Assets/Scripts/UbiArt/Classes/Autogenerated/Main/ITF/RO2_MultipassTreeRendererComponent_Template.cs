using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_MultipassTreeRendererComponent_Template : GraphicComponent_Template {
		[Serialize("passes")] public CList<RO2_BezierBranchRendererPass_Template> passes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(passes));
		}
		public override uint? ClassCRC => 0x3D64B146;
	}
}

