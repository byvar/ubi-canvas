namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_GyroControllerComponent : ActorComponent {
		public float cursorSmooth = 0.9f;
		public float rollBackCursorSmooth = 0.01f;
		public float rollBackCursorSmoothMidTarget = 0.1f;
		public float angleMultiplier = 1f;
		public float forcedAngleMultiplier = 0.5f;
		public bool activateOnTrigger;
		public float angleMin = -180f;
		public float angleMax = 180f;
		public float cameraRampUpCoeff = 0.05f;
		public float cameraRampDownCoeff = 0.05f;
		public float cameraZOffset = 5f;
		public float TVOffcameraZOffset = 20f;
		public Vec2d TVOffcameraPosOffset;
		public bool TVOffcameraResetMultiplier = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					cursorSmooth = s.Serialize<float>(cursorSmooth, name: "cursorSmooth");
					rollBackCursorSmooth = s.Serialize<float>(rollBackCursorSmooth, name: "rollBackCursorSmooth");
					rollBackCursorSmoothMidTarget = s.Serialize<float>(rollBackCursorSmoothMidTarget, name: "rollBackCursorSmoothMidTarget");
					angleMultiplier = s.Serialize<float>(angleMultiplier, name: "angleMultiplier");
					forcedAngleMultiplier = s.Serialize<float>(forcedAngleMultiplier, name: "forcedAngleMultiplier");
					activateOnTrigger = s.Serialize<bool>(activateOnTrigger, name: "activateOnTrigger", options: CSerializerObject.Options.BoolAsByte);
					angleMin = s.Serialize<float>(angleMin, name: "angleMin");
					angleMax = s.Serialize<float>(angleMax, name: "angleMax");
					cameraRampUpCoeff = s.Serialize<float>(cameraRampUpCoeff, name: "cameraRampUpCoeff");
					cameraRampDownCoeff = s.Serialize<float>(cameraRampDownCoeff, name: "cameraRampDownCoeff");
					cameraZOffset = s.Serialize<float>(cameraZOffset, name: "cameraZOffset");
					TVOffcameraZOffset = s.Serialize<float>(TVOffcameraZOffset, name: "TVOffcameraZOffset");
					TVOffcameraPosOffset = s.SerializeObject<Vec2d>(TVOffcameraPosOffset, name: "TVOffcameraPosOffset");
					TVOffcameraResetMultiplier = s.Serialize<bool>(TVOffcameraResetMultiplier, name: "TVOffcameraResetMultiplier", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					cursorSmooth = s.Serialize<float>(cursorSmooth, name: "cursorSmooth");
					rollBackCursorSmooth = s.Serialize<float>(rollBackCursorSmooth, name: "rollBackCursorSmooth");
					rollBackCursorSmoothMidTarget = s.Serialize<float>(rollBackCursorSmoothMidTarget, name: "rollBackCursorSmoothMidTarget");
					angleMultiplier = s.Serialize<float>(angleMultiplier, name: "angleMultiplier");
					forcedAngleMultiplier = s.Serialize<float>(forcedAngleMultiplier, name: "forcedAngleMultiplier");
					activateOnTrigger = s.Serialize<bool>(activateOnTrigger, name: "activateOnTrigger");
					angleMin = s.Serialize<float>(angleMin, name: "angleMin");
					angleMax = s.Serialize<float>(angleMax, name: "angleMax");
					cameraRampUpCoeff = s.Serialize<float>(cameraRampUpCoeff, name: "cameraRampUpCoeff");
					cameraRampDownCoeff = s.Serialize<float>(cameraRampDownCoeff, name: "cameraRampDownCoeff");
					cameraZOffset = s.Serialize<float>(cameraZOffset, name: "cameraZOffset");
					TVOffcameraZOffset = s.Serialize<float>(TVOffcameraZOffset, name: "TVOffcameraZOffset");
					TVOffcameraPosOffset = s.SerializeObject<Vec2d>(TVOffcameraPosOffset, name: "TVOffcameraPosOffset");
					TVOffcameraResetMultiplier = s.Serialize<bool>(TVOffcameraResetMultiplier, name: "TVOffcameraResetMultiplier");
				}
			}
		}
		public override uint? ClassCRC => 0x9B9EE530;
	}
}

