using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionAppearBackgroundLadders_Template : RO2_BTActionAppearBackground_Template {
		[Serialize("animClimbBack"             )] public StringID animClimbBack;
		[Serialize("animClimbFore"             )] public StringID animClimbFore;
		[Serialize("speedClimb"                )] public float speedClimb;
		[Serialize("jumpToActorMinTime"        )] public float jumpToActorMinTime;
		[Serialize("jumpToActorYFuncPoint0Dist")] public float jumpToActorYFuncPoint0Dist;
		[Serialize("jumpToActorYFuncPoint1Dist")] public float jumpToActorYFuncPoint1Dist;
		[Serialize("jumpToActorXZFuncPoint0T"  )] public float jumpToActorXZFuncPoint0T;
		[Serialize("jumpToActorXZFuncPoint1T"  )] public float jumpToActorXZFuncPoint1T;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animClimbBack));
			SerializeField(s, nameof(animClimbFore));
			SerializeField(s, nameof(speedClimb));
			SerializeField(s, nameof(jumpToActorMinTime));
			SerializeField(s, nameof(jumpToActorYFuncPoint0Dist));
			SerializeField(s, nameof(jumpToActorYFuncPoint1Dist));
			SerializeField(s, nameof(jumpToActorXZFuncPoint0T));
			SerializeField(s, nameof(jumpToActorXZFuncPoint1T));
		}
		public override uint? ClassCRC => 0xAF94397F;
	}
}

