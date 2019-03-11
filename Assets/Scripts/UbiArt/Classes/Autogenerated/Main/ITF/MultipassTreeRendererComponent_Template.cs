using UnityEngine;

namespace UbiArt.ITF {
	public partial class MultipassTreeRendererComponent_Template : GraphicComponent_Template {
		[Serialize("passes")] public CList<BezierBranchRendererPass_Template> passes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(passes));
		}
		public override uint? ClassCRC => 0x4DC93411;
	}
}

