using UnityEngine;

namespace UbiArt.ITF {
	public partial class RefractionComponent : ActorComponent {
		[Serialize("Primitive"  )] public GFX_RefractionPrimitive Primitive;
		[Serialize("DepthOffset")] public float DepthOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Primitive));
			SerializeField(s, nameof(DepthOffset));
		}
		public override uint? ClassCRC => 0x66703034;
	}
}

