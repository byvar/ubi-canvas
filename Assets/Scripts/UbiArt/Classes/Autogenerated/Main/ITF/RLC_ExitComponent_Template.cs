using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_ExitComponent_Template : ActorComponent_Template {
		[Serialize("shakeFlagsDistance")] public float shakeFlagsDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(shakeFlagsDistance));
		}
		public override uint? ClassCRC => 0x0101F5DF;
	}
}

