using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class BlurComponent : ActorComponent {
		public GFX_BlurPrimitive Primitive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Primitive = s.SerializeObject<GFX_BlurPrimitive>(Primitive, name: "Primitive");
		}
		public override uint? ClassCRC => 0x2A84C593;
	}
}

