using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionTorture_Template : BTAction_Template {
		[Serialize("animTortureHitHeadOnGround")] public StringID animTortureHitHeadOnGround;
		[Serialize("animTortureJumpOnVictim"   )] public StringID animTortureJumpOnVictim;
		[Serialize("forceSoftCol"              )] public float forceSoftCol;
		[Serialize("speedMinSoftCol"           )] public float speedMinSoftCol;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animTortureHitHeadOnGround));
			SerializeField(s, nameof(animTortureJumpOnVictim));
			SerializeField(s, nameof(forceSoftCol));
			SerializeField(s, nameof(speedMinSoftCol));
		}
		public override uint? ClassCRC => 0x929F99E8;
	}
}

