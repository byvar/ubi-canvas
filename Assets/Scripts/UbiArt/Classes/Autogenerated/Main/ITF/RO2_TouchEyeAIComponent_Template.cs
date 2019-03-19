using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TouchEyeAIComponent_Template : ActorComponent_Template {
		[Serialize("animIdle"   )] public StringID animIdle;
		[Serialize("animTouched")] public StringID animTouched;
		[Serialize("animStunned")] public StringID animStunned;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animIdle));
			SerializeField(s, nameof(animTouched));
			SerializeField(s, nameof(animStunned));
		}
		public override uint? ClassCRC => 0x1539E8F0;
	}
}

