using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)] // Definitely for a dragon
	public partial class Unknown_RL_123_sub_6E0620 : ActorComponent {
		public int DrawBezier;
		public int DrawSpeedModulation;
		public int UseAlwaysActive;
		public int UseFrontHitAnim;
		public int IsCineDragon;
		public int HasCollision;
		public float SinusSpeedX;
		public float SinusSpeedY;
		public float SinusAmplitudeX;
		public float SinusAmplitudeY;
		public float SinusLoopX;
		public float SinusLoopY;
		public float ResetRollSpeed;
		public float DeathZoneStartOffset;
		public float ModulateSpeedCoef;
		public float StartMaxSpeed;
		public float StartMinSpeed;
		public float StartingBackTan;
		public float StartingFrontTan;
		public float SlowDownDist;
		public float IKApproxamationCoeff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				DrawBezier = s.Serialize<int>(DrawBezier, name: "DrawBezier");
				DrawSpeedModulation = s.Serialize<int>(DrawSpeedModulation, name: "DrawSpeedModulation");
				UseAlwaysActive = s.Serialize<int>(UseAlwaysActive, name: "UseAlwaysActive");
				UseFrontHitAnim = s.Serialize<int>(UseFrontHitAnim, name: "UseFrontHitAnim");
				IsCineDragon = s.Serialize<int>(IsCineDragon, name: "IsCineDragon");
				HasCollision = s.Serialize<int>(HasCollision, name: "HasCollision");
				SinusSpeedX = s.Serialize<float>(SinusSpeedX, name: "SinusSpeedX");
				SinusSpeedY = s.Serialize<float>(SinusSpeedY, name: "SinusSpeedY");
				SinusAmplitudeX = s.Serialize<float>(SinusAmplitudeX, name: "SinusAmplitudeX");
				SinusAmplitudeY = s.Serialize<float>(SinusAmplitudeY, name: "SinusAmplitudeY");
				SinusLoopX = s.Serialize<float>(SinusLoopX, name: "SinusLoopX");
				SinusLoopY = s.Serialize<float>(SinusLoopY, name: "SinusLoopY");
				ResetRollSpeed = s.Serialize<float>(ResetRollSpeed, name: "ResetRollSpeed");
				DeathZoneStartOffset = s.Serialize<float>(DeathZoneStartOffset, name: "DeathZoneStartOffset");
				ModulateSpeedCoef = s.Serialize<float>(ModulateSpeedCoef, name: "ModulateSpeedCoef");
				StartMaxSpeed = s.Serialize<float>(StartMaxSpeed, name: "StartMaxSpeed");
				StartMinSpeed = s.Serialize<float>(StartMinSpeed, name: "StartMinSpeed");
				StartingBackTan = s.Serialize<float>(StartingBackTan, name: "StartingBackTan");
				StartingFrontTan = s.Serialize<float>(StartingFrontTan, name: "StartingFrontTan");
				SlowDownDist = s.Serialize<float>(SlowDownDist, name: "SlowDownDist");
				IKApproxamationCoeff = s.Serialize<float>(IKApproxamationCoeff, name: "IKApproxamationCoeff");
			}
		}
		public override uint? ClassCRC => 0xD8EDA143;
	}
}

