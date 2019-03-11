using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIBlowOffAction_Template : AIAction_Template {
		[Serialize("aiFlyMaxSpeed"                 )] public float aiFlyMaxSpeed;
		[Serialize("aiFlyForceMultiplier"          )] public float aiFlyForceMultiplier;
		[Serialize("aiFlyLateralFrequency"         )] public float aiFlyLateralFrequency;
		[Serialize("aiFlyLateralAmplitude"         )] public Angle aiFlyLateralAmplitude;
		[Serialize("aiFlyPitchFrequency"           )] public float aiFlyPitchFrequency;
		[Serialize("aiFlyPitchAmplitude"           )] public Angle aiFlyPitchAmplitude;
		[Serialize("aiFlyKeepDirDuration"          )] public float aiFlyKeepDirDuration;
		[Serialize("aiFlyKeepDirTransitionDuration")] public float aiFlyKeepDirTransitionDuration;
		[Serialize("aiFlyPostKeepDirLifetime"      )] public float aiFlyPostKeepDirLifetime;
		[Serialize("aiFlyNoMovementLifeTime"       )] public float aiFlyNoMovementLifeTime;
		[Serialize("aiFlyNoMovementEpsilon"        )] public float aiFlyNoMovementEpsilon;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(aiFlyMaxSpeed));
			SerializeField(s, nameof(aiFlyForceMultiplier));
			SerializeField(s, nameof(aiFlyLateralFrequency));
			SerializeField(s, nameof(aiFlyLateralAmplitude));
			SerializeField(s, nameof(aiFlyPitchFrequency));
			SerializeField(s, nameof(aiFlyPitchAmplitude));
			SerializeField(s, nameof(aiFlyKeepDirDuration));
			SerializeField(s, nameof(aiFlyKeepDirTransitionDuration));
			SerializeField(s, nameof(aiFlyPostKeepDirLifetime));
			SerializeField(s, nameof(aiFlyNoMovementLifeTime));
			SerializeField(s, nameof(aiFlyNoMovementEpsilon));
		}
		public override uint? ClassCRC => 0x6E42C62F;
	}
}

