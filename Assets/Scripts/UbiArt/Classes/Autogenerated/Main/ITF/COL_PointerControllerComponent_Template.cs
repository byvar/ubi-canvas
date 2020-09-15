using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PointerControllerComponent_Template : CSerializable {
		[Description("The speed at which the actor follows the mouse pointer, between 0 and 1.")]
		[Serialize("mouseFollowSpeed"                )] public float mouseFollowSpeed;
		[Serialize("mouseSpeedAnimThreshold"         )] public float mouseSpeedAnimThreshold;
		[Serialize("initialMovementThreshold"        )] public float initialMovementThreshold;
		[Serialize("pointerReachThreshold"           )] public float pointerReachThreshold;
		[Serialize("pointerReachDampFactor"          )] public float pointerReachDampFactor;
		[Serialize("pointerFollowDampFactor"         )] public float pointerFollowDampFactor;
		[Serialize("pointerMovementDashAnimThreshold")] public float pointerMovementDashAnimThreshold;
		[Serialize("dragSpeed"                       )] public Vec2d dragSpeed;
		[Serialize("accelDragFactor"                 )] public float accelDragFactor;
		[Serialize("decelDragFactor"                 )] public float decelDragFactor;
		[Serialize("dragSlowdownFactor"              )] public float dragSlowdownFactor;
		[Serialize("dragXAxisAlignThreshold"         )] public float dragXAxisAlignThreshold;
		[Serialize("dragYAxisAlignThreshold"         )] public float dragYAxisAlignThreshold;
		[Serialize("dragDashAnimThreshold"           )] public float dragDashAnimThreshold;
		[Serialize("touchDurationToActivate"         )] public float touchDurationToActivate;
		[Serialize("activeInUIEnvironment"           )] public int activeInUIEnvironment;
		[Serialize("activeInGameplayEnvironment"     )] public int activeInGameplayEnvironment;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(mouseFollowSpeed));
			SerializeField(s, nameof(mouseSpeedAnimThreshold));
			SerializeField(s, nameof(initialMovementThreshold));
			SerializeField(s, nameof(pointerReachThreshold));
			SerializeField(s, nameof(pointerReachDampFactor));
			SerializeField(s, nameof(pointerFollowDampFactor));
			SerializeField(s, nameof(pointerMovementDashAnimThreshold));
			SerializeField(s, nameof(dragSpeed));
			SerializeField(s, nameof(accelDragFactor));
			SerializeField(s, nameof(decelDragFactor));
			SerializeField(s, nameof(dragSlowdownFactor));
			SerializeField(s, nameof(dragXAxisAlignThreshold));
			SerializeField(s, nameof(dragYAxisAlignThreshold));
			SerializeField(s, nameof(dragDashAnimThreshold));
			SerializeField(s, nameof(touchDurationToActivate));
			SerializeField(s, nameof(activeInUIEnvironment));
			SerializeField(s, nameof(activeInGameplayEnvironment));
		}
		public override uint? ClassCRC => 0xDCC69EFD;
	}
}

