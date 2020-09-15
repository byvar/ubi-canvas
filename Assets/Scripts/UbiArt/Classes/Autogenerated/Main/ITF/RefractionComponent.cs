using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RefractionComponent : ActorComponent {
		public GFX_RefractionPrimitive Primitive;
		public float DepthOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Primitive = s.SerializeObject<GFX_RefractionPrimitive>(Primitive, name: "Primitive");
			DepthOffset = s.Serialize<float>(DepthOffset, name: "DepthOffset");
		}
		public override uint? ClassCRC => 0x66703034;
	}
}

