namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleCameraComponent : BaseCameraComponent {
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
		public Curve2D actionStartCurveXY;
		[Description("Curve in Z to move the camera when starting the action.")]
		public Curve2D actionStartCurveZ;
		[Description("Fov curve to move the camera when starting the action.")]
		public Curve2D actionStartCurveFov;
		[Description("Zoom distance when starting the action.")]
		public float actionStartZoom;
		[Description("Fov when starting the action.")]
		public float actionStartFov;
		[Description("Duration of the camera move when starting the action.")]
		public float actionStartDuration;
		[Description("Curve in XY to move the camera when receiving the action.")]
		public Curve2D actionReceptionCurveXY;
		[Description("Curve in Z to move the camera when receiving the action.")]
		public Curve2D actionReceptionCurveZ;
		[Description("Fov curve to move the camera when receiving the action.")]
		public Curve2D actionReceptionCurveFov;
		[Description("Zoom distance when receiving the action.")]
		public float actionReceptionZoom;
		[Description("Fov when receiving the action.")]
		public float actionReceptionFov;
		[Description("Duration of the camera move when receiving the action.")]
		public float actionReceptionDuration;
		[Description("Curve in XY to move the camera when ending the action.")]
		public Curve2D actionEndCurveXY;
		[Description("Curve in Z to move the camera when ending the action.")]
		public Curve2D actionEndCurveZ;
		[Description("Fov curve to move the camera when ending the action.")]
		public Curve2D actionEndCurveFov;
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
				actionStartCurveXY = s.SerializeObject<Curve2D>(actionStartCurveXY, name: "actionStartCurveXY");
				actionStartCurveZ = s.SerializeObject<Curve2D>(actionStartCurveZ, name: "actionStartCurveZ");
				actionStartCurveFov = s.SerializeObject<Curve2D>(actionStartCurveFov, name: "actionStartCurveFov");
				actionStartZoom = s.Serialize<float>(actionStartZoom, name: "actionStartZoom");
				actionStartFov = s.Serialize<float>(actionStartFov, name: "actionStartFov");
				actionStartDuration = s.Serialize<float>(actionStartDuration, name: "actionStartDuration");
				actionReceptionCurveXY = s.SerializeObject<Curve2D>(actionReceptionCurveXY, name: "actionReceptionCurveXY");
				actionReceptionCurveZ = s.SerializeObject<Curve2D>(actionReceptionCurveZ, name: "actionReceptionCurveZ");
				actionReceptionCurveFov = s.SerializeObject<Curve2D>(actionReceptionCurveFov, name: "actionReceptionCurveFov");
				actionReceptionZoom = s.Serialize<float>(actionReceptionZoom, name: "actionReceptionZoom");
				actionReceptionFov = s.Serialize<float>(actionReceptionFov, name: "actionReceptionFov");
				actionReceptionDuration = s.Serialize<float>(actionReceptionDuration, name: "actionReceptionDuration");
				actionEndCurveXY = s.SerializeObject<Curve2D>(actionEndCurveXY, name: "actionEndCurveXY");
				actionEndCurveZ = s.SerializeObject<Curve2D>(actionEndCurveZ, name: "actionEndCurveZ");
				actionEndCurveFov = s.SerializeObject<Curve2D>(actionEndCurveFov, name: "actionEndCurveFov");
				actionEndDuration = s.Serialize<float>(actionEndDuration, name: "actionEndDuration");
			}
		}
		public override uint? ClassCRC => 0x8405D2AC;
	}
}

