using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_PlayerTouchInputController_Template : TemplateObj {
		[Serialize("JumpCommandDurationMaxAllowed"   )] public float JumpCommandDurationMaxAllowed;
		[Serialize("SwipeDetectionDuration"          )] public float SwipeDetectionDuration;
		[Serialize("HoldingJumpHelicoTriggerDuration")] public float HoldingJumpHelicoTriggerDuration;
		[Serialize("AirSwipeDetectionDuration"       )] public float AirSwipeDetectionDuration;
		[Serialize("HangingAttackDuration"           )] public float HangingAttackDuration;
		[Serialize("HelicoAttackDuration"            )] public float HelicoAttackDuration;
		[Serialize("DefaultAttackDuration"           )] public float DefaultAttackDuration;
		[Serialize("HoldDurationToIgnoreSwipe"       )] public float HoldDurationToIgnoreSwipe;
		[Serialize("MovingDurationToCancelJump"      )] public float MovingDurationToCancelJump;
		[Serialize("JumpInputMemoDuration"           )] public float JumpInputMemoDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(JumpCommandDurationMaxAllowed));
			SerializeField(s, nameof(SwipeDetectionDuration));
			SerializeField(s, nameof(HoldingJumpHelicoTriggerDuration));
			SerializeField(s, nameof(AirSwipeDetectionDuration));
			SerializeField(s, nameof(HangingAttackDuration));
			SerializeField(s, nameof(HelicoAttackDuration));
			SerializeField(s, nameof(DefaultAttackDuration));
			SerializeField(s, nameof(HoldDurationToIgnoreSwipe));
			SerializeField(s, nameof(MovingDurationToCancelJump));
			SerializeField(s, nameof(JumpInputMemoDuration));
		}
		public override uint? ClassCRC => 0x570711FF;
	}
}

