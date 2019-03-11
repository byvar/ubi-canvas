using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FluidEvaluatorComponent_Template : ActorComponent_Template {
		[Serialize("DrawRasterization")] public bool DrawRasterization;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DrawRasterization));
		}
		public override uint? ClassCRC => 0x22232221;
	}
}

