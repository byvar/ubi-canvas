using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_PlayerTouchInputController_Template : TemplateObj {
		public float JumpCommandDurationMaxAllowed;
		public float SwipeDetectionDuration;
		public float HoldingJumpHelicoTriggerDuration;
		public float AirSwipeDetectionDuration;
		public float HangingAttackDuration;
		public float HelicoAttackDuration;
		public float DefaultAttackDuration;
		public float HoldDurationToIgnoreSwipe;
		public float MovingDurationToCancelJump;
		public float JumpInputMemoDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			JumpCommandDurationMaxAllowed = s.Serialize<float>(JumpCommandDurationMaxAllowed, name: "JumpCommandDurationMaxAllowed");
			SwipeDetectionDuration = s.Serialize<float>(SwipeDetectionDuration, name: "SwipeDetectionDuration");
			HoldingJumpHelicoTriggerDuration = s.Serialize<float>(HoldingJumpHelicoTriggerDuration, name: "HoldingJumpHelicoTriggerDuration");
			AirSwipeDetectionDuration = s.Serialize<float>(AirSwipeDetectionDuration, name: "AirSwipeDetectionDuration");
			HangingAttackDuration = s.Serialize<float>(HangingAttackDuration, name: "HangingAttackDuration");
			HelicoAttackDuration = s.Serialize<float>(HelicoAttackDuration, name: "HelicoAttackDuration");
			DefaultAttackDuration = s.Serialize<float>(DefaultAttackDuration, name: "DefaultAttackDuration");
			HoldDurationToIgnoreSwipe = s.Serialize<float>(HoldDurationToIgnoreSwipe, name: "HoldDurationToIgnoreSwipe");
			MovingDurationToCancelJump = s.Serialize<float>(MovingDurationToCancelJump, name: "MovingDurationToCancelJump");
			JumpInputMemoDuration = s.Serialize<float>(JumpInputMemoDuration, name: "JumpInputMemoDuration");
		}
		public override uint? ClassCRC => 0x570711FF;
	}
}

