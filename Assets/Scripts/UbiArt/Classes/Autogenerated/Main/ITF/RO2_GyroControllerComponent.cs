using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GyroControllerComponent : ActorComponent {
		[Serialize("cursorSmooth"                 )] public float cursorSmooth;
		[Serialize("rollBackCursorSmooth"         )] public float rollBackCursorSmooth;
		[Serialize("rollBackCursorSmoothMidTarget")] public float rollBackCursorSmoothMidTarget;
		[Serialize("angleMultiplier"              )] public float angleMultiplier;
		[Serialize("forcedAngleMultiplier"        )] public float forcedAngleMultiplier;
		[Serialize("activateOnTrigger"            )] public bool activateOnTrigger;
		[Serialize("angleMin"                     )] public float angleMin;
		[Serialize("angleMax"                     )] public float angleMax;
		[Serialize("cameraRampUpCoeff"            )] public float cameraRampUpCoeff;
		[Serialize("cameraRampDownCoeff"          )] public float cameraRampDownCoeff;
		[Serialize("cameraZOffset"                )] public float cameraZOffset;
		[Serialize("TVOffcameraZOffset"           )] public float TVOffcameraZOffset;
		[Serialize("TVOffcameraPosOffset"         )] public Vector2 TVOffcameraPosOffset;
		[Serialize("TVOffcameraResetMultiplier"   )] public bool TVOffcameraResetMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(cursorSmooth));
					SerializeField(s, nameof(rollBackCursorSmooth));
					SerializeField(s, nameof(rollBackCursorSmoothMidTarget));
					SerializeField(s, nameof(angleMultiplier));
					SerializeField(s, nameof(forcedAngleMultiplier));
					SerializeField(s, nameof(activateOnTrigger), boolAsByte: true);
					SerializeField(s, nameof(angleMin));
					SerializeField(s, nameof(angleMax));
					SerializeField(s, nameof(cameraRampUpCoeff));
					SerializeField(s, nameof(cameraRampDownCoeff));
					SerializeField(s, nameof(cameraZOffset));
					SerializeField(s, nameof(TVOffcameraZOffset));
					SerializeField(s, nameof(TVOffcameraPosOffset));
					SerializeField(s, nameof(TVOffcameraResetMultiplier), boolAsByte: true);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(cursorSmooth));
					SerializeField(s, nameof(rollBackCursorSmooth));
					SerializeField(s, nameof(rollBackCursorSmoothMidTarget));
					SerializeField(s, nameof(angleMultiplier));
					SerializeField(s, nameof(forcedAngleMultiplier));
					SerializeField(s, nameof(activateOnTrigger));
					SerializeField(s, nameof(angleMin));
					SerializeField(s, nameof(angleMax));
					SerializeField(s, nameof(cameraRampUpCoeff));
					SerializeField(s, nameof(cameraRampDownCoeff));
					SerializeField(s, nameof(cameraZOffset));
					SerializeField(s, nameof(TVOffcameraZOffset));
					SerializeField(s, nameof(TVOffcameraPosOffset));
					SerializeField(s, nameof(TVOffcameraResetMultiplier));
				}
			}
		}
		public override uint? ClassCRC => 0x9B9EE530;
	}
}

