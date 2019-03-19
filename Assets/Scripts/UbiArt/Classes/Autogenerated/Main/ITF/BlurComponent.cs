using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class BlurComponent : ActorComponent {
		[Serialize("Primitive")] public GFX_BlurPrimitive Primitive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Primitive));
		}
		public override uint? ClassCRC => 0x2A84C593;
	}
}

