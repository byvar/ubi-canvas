using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_FishingRodComponent_Template : ActorComponent_Template {
		[Serialize("animExplode")] public StringID animExplode;
		[Serialize("animDropped")] public StringID animDropped;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animExplode));
			SerializeField(s, nameof(animDropped));
		}
		public override uint? ClassCRC => 0x5B4A4888;
	}
}

