using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleCameraComponent : CSerializable {
		[Description("Default fov.")]
		[Serialize("defaultFov"             )] public float defaultFov;
		[Description("Offset applied to the initial position of the camera.")]
		[Serialize("baseOffset"             )] public Vec3d baseOffset;
		[Description("Offset limit in X when moving the camera.")]
		[Serialize("offsetLimitX"           )] public float offsetLimitX;
		[Description("Offset limit in Y when moving the camera.")]
		[Serialize("offsetLimitY"           )] public float offsetLimitY;
		[Description("Delay before starting the camera move on action start.")]
		[Serialize("actionStartDelay"       )] public float actionStartDelay;
		[Description("Curve in XY to move the camera when starting the action.")]
		[Serialize("actionStartCurveXY"     )] public Placeholder actionStartCurveXY;
		[Description("Curve in Z to move the camera when starting the action.")]
		[Serialize("actionStartCurveZ"      )] public Placeholder actionStartCurveZ;
		[Description("Fov curve to move the camera when starting the action.")]
		[Serialize("actionStartCurveFov"    )] public Placeholder actionStartCurveFov;
		[Description("Zoom distance when starting the action.")]
		[Serialize("actionStartZoom"        )] public float actionStartZoom;
		[Description("Fov when starting the action.")]
		[Serialize("actionStartFov"         )] public float actionStartFov;
		[Description("Duration of the camera move when starting the action.")]
		[Serialize("actionStartDuration"    )] public float actionStartDuration;
		[Description("Curve in XY to move the camera when receiving the action.")]
		[Serialize("actionReceptionCurveXY" )] public Placeholder actionReceptionCurveXY;
		[Description("Curve in Z to move the camera when receiving the action.")]
		[Serialize("actionReceptionCurveZ"  )] public Placeholder actionReceptionCurveZ;
		[Description("Fov curve to move the camera when receiving the action.")]
		[Serialize("actionReceptionCurveFov")] public Placeholder actionReceptionCurveFov;
		[Description("Zoom distance when receiving the action.")]
		[Serialize("actionReceptionZoom"    )] public float actionReceptionZoom;
		[Description("Fov when receiving the action.")]
		[Serialize("actionReceptionFov"     )] public float actionReceptionFov;
		[Description("Duration of the camera move when receiving the action.")]
		[Serialize("actionReceptionDuration")] public float actionReceptionDuration;
		[Description("Curve in XY to move the camera when ending the action.")]
		[Serialize("actionEndCurveXY"       )] public Placeholder actionEndCurveXY;
		[Description("Curve in Z to move the camera when ending the action.")]
		[Serialize("actionEndCurveZ"        )] public Placeholder actionEndCurveZ;
		[Description("Fov curve to move the camera when ending the action.")]
		[Serialize("actionEndCurveFov"      )] public Placeholder actionEndCurveFov;
		[Description("Duration of the camera move when ending the action.")]
		[Serialize("actionEndDuration"      )] public float actionEndDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(defaultFov));
				SerializeField(s, nameof(baseOffset));
				SerializeField(s, nameof(offsetLimitX));
				SerializeField(s, nameof(offsetLimitY));
				SerializeField(s, nameof(actionStartDelay));
				SerializeField(s, nameof(actionStartCurveXY));
				SerializeField(s, nameof(actionStartCurveZ));
				SerializeField(s, nameof(actionStartCurveFov));
				SerializeField(s, nameof(actionStartZoom));
				SerializeField(s, nameof(actionStartFov));
				SerializeField(s, nameof(actionStartDuration));
				SerializeField(s, nameof(actionReceptionCurveXY));
				SerializeField(s, nameof(actionReceptionCurveZ));
				SerializeField(s, nameof(actionReceptionCurveFov));
				SerializeField(s, nameof(actionReceptionZoom));
				SerializeField(s, nameof(actionReceptionFov));
				SerializeField(s, nameof(actionReceptionDuration));
				SerializeField(s, nameof(actionEndCurveXY));
				SerializeField(s, nameof(actionEndCurveZ));
				SerializeField(s, nameof(actionEndCurveFov));
				SerializeField(s, nameof(actionEndDuration));
			}
		}
		public override uint? ClassCRC => 0x6CEE05D6;
	}
}

