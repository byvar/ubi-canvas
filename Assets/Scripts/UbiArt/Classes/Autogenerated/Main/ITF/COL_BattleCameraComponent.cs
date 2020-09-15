using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleCameraComponent : CSerializable {
		[Description("Default fov.")]
		public float defaultFov;
		[Description("Offset applied to the initial position of the camera.")]
		public Vec3d baseOffset;
		[Description("Offset limit in X when moving the camera.")]
		public float offsetLimitX;
		[Description("Offset limit in Y when moving the camera.")]
		public float offsetLimitY;
		[Description("Delay before starting the camera move on action start.")]
		public float actionStartDelay;
		[Description("Curve in XY to move the camera when starting the action.")]
		public Placeholder actionStartCurveXY;
		[Description("Curve in Z to move the camera when starting the action.")]
		public Placeholder actionStartCurveZ;
		[Description("Fov curve to move the camera when starting the action.")]
		public Placeholder actionStartCurveFov;
		[Description("Zoom distance when starting the action.")]
		public float actionStartZoom;
		[Description("Fov when starting the action.")]
		public float actionStartFov;
		[Description("Duration of the camera move when starting the action.")]
		public float actionStartDuration;
		[Description("Curve in XY to move the camera when receiving the action.")]
		public Placeholder actionReceptionCurveXY;
		[Description("Curve in Z to move the camera when receiving the action.")]
		public Placeholder actionReceptionCurveZ;
		[Description("Fov curve to move the camera when receiving the action.")]
		public Placeholder actionReceptionCurveFov;
		[Description("Zoom distance when receiving the action.")]
		public float actionReceptionZoom;
		[Description("Fov when receiving the action.")]
		public float actionReceptionFov;
		[Description("Duration of the camera move when receiving the action.")]
		public float actionReceptionDuration;
		[Description("Curve in XY to move the camera when ending the action.")]
		public Placeholder actionEndCurveXY;
		[Description("Curve in Z to move the camera when ending the action.")]
		public Placeholder actionEndCurveZ;
		[Description("Fov curve to move the camera when ending the action.")]
		public Placeholder actionEndCurveFov;
		[Description("Duration of the camera move when ending the action.")]
		public float actionEndDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				defaultFov = s.Serialize<float>(defaultFov, name: "defaultFov");
				baseOffset = s.SerializeObject<Vec3d>(baseOffset, name: "baseOffset");
				offsetLimitX = s.Serialize<float>(offsetLimitX, name: "offsetLimitX");
				offsetLimitY = s.Serialize<float>(offsetLimitY, name: "offsetLimitY");
				actionStartDelay = s.Serialize<float>(actionStartDelay, name: "actionStartDelay");
				actionStartCurveXY = s.SerializeObject<Placeholder>(actionStartCurveXY, name: "actionStartCurveXY");
				actionStartCurveZ = s.SerializeObject<Placeholder>(actionStartCurveZ, name: "actionStartCurveZ");
				actionStartCurveFov = s.SerializeObject<Placeholder>(actionStartCurveFov, name: "actionStartCurveFov");
				actionStartZoom = s.Serialize<float>(actionStartZoom, name: "actionStartZoom");
				actionStartFov = s.Serialize<float>(actionStartFov, name: "actionStartFov");
				actionStartDuration = s.Serialize<float>(actionStartDuration, name: "actionStartDuration");
				actionReceptionCurveXY = s.SerializeObject<Placeholder>(actionReceptionCurveXY, name: "actionReceptionCurveXY");
				actionReceptionCurveZ = s.SerializeObject<Placeholder>(actionReceptionCurveZ, name: "actionReceptionCurveZ");
				actionReceptionCurveFov = s.SerializeObject<Placeholder>(actionReceptionCurveFov, name: "actionReceptionCurveFov");
				actionReceptionZoom = s.Serialize<float>(actionReceptionZoom, name: "actionReceptionZoom");
				actionReceptionFov = s.Serialize<float>(actionReceptionFov, name: "actionReceptionFov");
				actionReceptionDuration = s.Serialize<float>(actionReceptionDuration, name: "actionReceptionDuration");
				actionEndCurveXY = s.SerializeObject<Placeholder>(actionEndCurveXY, name: "actionEndCurveXY");
				actionEndCurveZ = s.SerializeObject<Placeholder>(actionEndCurveZ, name: "actionEndCurveZ");
				actionEndCurveFov = s.SerializeObject<Placeholder>(actionEndCurveFov, name: "actionEndCurveFov");
				actionEndDuration = s.Serialize<float>(actionEndDuration, name: "actionEndDuration");
			}
		}
		public override uint? ClassCRC => 0x6CEE05D6;
	}
}

