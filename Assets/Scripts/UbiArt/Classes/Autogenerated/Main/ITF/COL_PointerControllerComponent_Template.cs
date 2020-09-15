using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PointerControllerComponent_Template : CSerializable {
		[Description("The speed at which the actor follows the mouse pointer, between 0 and 1.")]
		public float mouseFollowSpeed;
		public float mouseSpeedAnimThreshold;
		public float initialMovementThreshold;
		public float pointerReachThreshold;
		public float pointerReachDampFactor;
		public float pointerFollowDampFactor;
		public float pointerMovementDashAnimThreshold;
		public Vec2d dragSpeed;
		public float accelDragFactor;
		public float decelDragFactor;
		public float dragSlowdownFactor;
		public float dragXAxisAlignThreshold;
		public float dragYAxisAlignThreshold;
		public float dragDashAnimThreshold;
		public float touchDurationToActivate;
		public int activeInUIEnvironment;
		public int activeInGameplayEnvironment;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mouseFollowSpeed = s.Serialize<float>(mouseFollowSpeed, name: "mouseFollowSpeed");
			mouseSpeedAnimThreshold = s.Serialize<float>(mouseSpeedAnimThreshold, name: "mouseSpeedAnimThreshold");
			initialMovementThreshold = s.Serialize<float>(initialMovementThreshold, name: "initialMovementThreshold");
			pointerReachThreshold = s.Serialize<float>(pointerReachThreshold, name: "pointerReachThreshold");
			pointerReachDampFactor = s.Serialize<float>(pointerReachDampFactor, name: "pointerReachDampFactor");
			pointerFollowDampFactor = s.Serialize<float>(pointerFollowDampFactor, name: "pointerFollowDampFactor");
			pointerMovementDashAnimThreshold = s.Serialize<float>(pointerMovementDashAnimThreshold, name: "pointerMovementDashAnimThreshold");
			dragSpeed = s.SerializeObject<Vec2d>(dragSpeed, name: "dragSpeed");
			accelDragFactor = s.Serialize<float>(accelDragFactor, name: "accelDragFactor");
			decelDragFactor = s.Serialize<float>(decelDragFactor, name: "decelDragFactor");
			dragSlowdownFactor = s.Serialize<float>(dragSlowdownFactor, name: "dragSlowdownFactor");
			dragXAxisAlignThreshold = s.Serialize<float>(dragXAxisAlignThreshold, name: "dragXAxisAlignThreshold");
			dragYAxisAlignThreshold = s.Serialize<float>(dragYAxisAlignThreshold, name: "dragYAxisAlignThreshold");
			dragDashAnimThreshold = s.Serialize<float>(dragDashAnimThreshold, name: "dragDashAnimThreshold");
			touchDurationToActivate = s.Serialize<float>(touchDurationToActivate, name: "touchDurationToActivate");
			activeInUIEnvironment = s.Serialize<int>(activeInUIEnvironment, name: "activeInUIEnvironment");
			activeInGameplayEnvironment = s.Serialize<int>(activeInGameplayEnvironment, name: "activeInGameplayEnvironment");
		}
		public override uint? ClassCRC => 0xDCC69EFD;
	}
}

