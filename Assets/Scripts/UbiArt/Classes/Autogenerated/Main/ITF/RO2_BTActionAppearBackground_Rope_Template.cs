using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionAppearBackground_Rope_Template : BTAction_Template {
		[Serialize("animStandBack"             )] public StringID animStandBack;
		[Serialize("animClimbBack"             )] public StringID animClimbBack;
		[Serialize("animJumpBack"              )] public StringID animJumpBack;
		[Serialize("animLandBack"              )] public StringID animLandBack;
		[Serialize("animStandFore"             )] public StringID animStandFore;
		[Serialize("animClimbFore"             )] public StringID animClimbFore;
		[Serialize("animJumpFore"              )] public StringID animJumpFore;
		[Serialize("animLandFore"              )] public StringID animLandFore;
		[Serialize("waitForTrigger"            )] public bool waitForTrigger;
		[Serialize("disablePhys"               )] public bool disablePhys;
		[Serialize("resetAngle"                )] public bool resetAngle;
		[Serialize("speedClimb"                )] public float speedClimb;
		[Serialize("jumpToActorMinTime"        )] public float jumpToActorMinTime;
		[Serialize("jumpToActorYFuncPoint0Dist")] public float jumpToActorYFuncPoint0Dist;
		[Serialize("jumpToActorYFuncPoint1Dist")] public float jumpToActorYFuncPoint1Dist;
		[Serialize("jumpToActorXZFuncPoint0T"  )] public float jumpToActorXZFuncPoint0T;
		[Serialize("jumpToActorXZFuncPoint1T"  )] public float jumpToActorXZFuncPoint1T;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animStandBack));
			SerializeField(s, nameof(animClimbBack));
			SerializeField(s, nameof(animJumpBack));
			SerializeField(s, nameof(animLandBack));
			SerializeField(s, nameof(animStandFore));
			SerializeField(s, nameof(animClimbFore));
			SerializeField(s, nameof(animJumpFore));
			SerializeField(s, nameof(animLandFore));
			SerializeField(s, nameof(waitForTrigger));
			SerializeField(s, nameof(disablePhys));
			SerializeField(s, nameof(resetAngle));
			SerializeField(s, nameof(speedClimb));
			SerializeField(s, nameof(jumpToActorMinTime));
			SerializeField(s, nameof(jumpToActorYFuncPoint0Dist));
			SerializeField(s, nameof(jumpToActorYFuncPoint1Dist));
			SerializeField(s, nameof(jumpToActorXZFuncPoint0T));
			SerializeField(s, nameof(jumpToActorXZFuncPoint1T));
		}
		public override uint? ClassCRC => 0x84C8ACC4;
	}
}

