using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MagicianHatComponent_Template : ActorComponent_Template {
		[Serialize("animStand" )] public StringID animStand;
		[Serialize("animBounce")] public StringID animBounce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animStand));
			SerializeField(s, nameof(animBounce));
		}
		public override uint? ClassCRC => 0x3D13B4AC;
	}
}

