using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TrapComponent_Template : ActorComponent_Template {
		[Serialize("animOff"    )] public StringID animOff;
		[Serialize("animTrapped")] public StringID animTrapped;
		[Serialize("activatedFx")] public StringID activatedFx;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animOff));
			SerializeField(s, nameof(animTrapped));
			SerializeField(s, nameof(activatedFx));
		}
		public override uint? ClassCRC => 0x2B10AC82;
	}
}

