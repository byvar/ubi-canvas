using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_112_sub_6E0620 : CSerializable {
		[Serialize("DrawBezier"          )] public bool DrawBezier;
		[Serialize("DrawSpeedModulation" )] public bool DrawSpeedModulation;
		[Serialize("UseAlwaysActive"     )] public bool UseAlwaysActive;
		[Serialize("UseFrontHitAnim"     )] public bool UseFrontHitAnim;
		[Serialize("IsCineDragon"        )] public bool IsCineDragon;
		[Serialize("HasCollision"        )] public bool HasCollision;
		[Serialize("SinusSpeedX"         )] public float SinusSpeedX;
		[Serialize("SinusSpeedY"         )] public float SinusSpeedY;
		[Serialize("SinusAmplitudeX"     )] public float SinusAmplitudeX;
		[Serialize("SinusAmplitudeY"     )] public float SinusAmplitudeY;
		[Serialize("SinusLoopX"          )] public float SinusLoopX;
		[Serialize("SinusLoopY"          )] public float SinusLoopY;
		[Serialize("ResetRollSpeed"      )] public float ResetRollSpeed;
		[Serialize("DeathZoneStartOffset")] public float DeathZoneStartOffset;
		[Serialize("ModulateSpeedCoef"   )] public float ModulateSpeedCoef;
		[Serialize("StartMaxSpeed"       )] public float StartMaxSpeed;
		[Serialize("StartMinSpeed"       )] public float StartMinSpeed;
		[Serialize("StartingBackTan"     )] public float StartingBackTan;
		[Serialize("StartingFrontTan"    )] public float StartingFrontTan;
		[Serialize("SlowDownDist"        )] public float SlowDownDist;
		[Serialize("IKApproxamationCoeff")] public float IKApproxamationCoeff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(DrawBezier));
				SerializeField(s, nameof(DrawSpeedModulation));
				SerializeField(s, nameof(UseAlwaysActive));
				SerializeField(s, nameof(UseFrontHitAnim));
				SerializeField(s, nameof(IsCineDragon));
				SerializeField(s, nameof(HasCollision));
				SerializeField(s, nameof(SinusSpeedX));
				SerializeField(s, nameof(SinusSpeedY));
				SerializeField(s, nameof(SinusAmplitudeX));
				SerializeField(s, nameof(SinusAmplitudeY));
				SerializeField(s, nameof(SinusLoopX));
				SerializeField(s, nameof(SinusLoopY));
				SerializeField(s, nameof(ResetRollSpeed));
				SerializeField(s, nameof(DeathZoneStartOffset));
				SerializeField(s, nameof(ModulateSpeedCoef));
				SerializeField(s, nameof(StartMaxSpeed));
				SerializeField(s, nameof(StartMinSpeed));
				SerializeField(s, nameof(StartingBackTan));
				SerializeField(s, nameof(StartingFrontTan));
				SerializeField(s, nameof(SlowDownDist));
				SerializeField(s, nameof(IKApproxamationCoeff));
			}
		}
		public override uint? ClassCRC => 0xD8EDA143;
	}
}

