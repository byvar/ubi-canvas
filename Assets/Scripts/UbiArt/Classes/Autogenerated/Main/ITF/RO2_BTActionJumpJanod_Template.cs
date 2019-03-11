using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionJumpJanod_Template : BTAction_Template {
		[Serialize("speedJump"   )] public float speedJump;
		[Serialize("timeOnGround")] public float timeOnGround;
		[Serialize("animAnticip" )] public StringID animAnticip;
		[Serialize("animJump"    )] public StringID animJump;
		[Serialize("animFall"    )] public StringID animFall;
		[Serialize("animLanding" )] public StringID animLanding;
		[Serialize("animIdle"    )] public StringID animIdle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speedJump));
			SerializeField(s, nameof(timeOnGround));
			SerializeField(s, nameof(animAnticip));
			SerializeField(s, nameof(animJump));
			SerializeField(s, nameof(animFall));
			SerializeField(s, nameof(animLanding));
			SerializeField(s, nameof(animIdle));
		}
		public override uint? ClassCRC => 0xF0FBD948;
	}
}

