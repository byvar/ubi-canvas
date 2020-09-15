using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIBlowOffAction_Template : AIAction_Template {
		public float aiFlyMaxSpeed;
		public float aiFlyForceMultiplier;
		public float aiFlyLateralFrequency;
		public Angle aiFlyLateralAmplitude;
		public float aiFlyPitchFrequency;
		public Angle aiFlyPitchAmplitude;
		public float aiFlyKeepDirDuration;
		public float aiFlyKeepDirTransitionDuration;
		public float aiFlyPostKeepDirLifetime;
		public float aiFlyNoMovementLifeTime;
		public float aiFlyNoMovementEpsilon;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			aiFlyMaxSpeed = s.Serialize<float>(aiFlyMaxSpeed, name: "aiFlyMaxSpeed");
			aiFlyForceMultiplier = s.Serialize<float>(aiFlyForceMultiplier, name: "aiFlyForceMultiplier");
			aiFlyLateralFrequency = s.Serialize<float>(aiFlyLateralFrequency, name: "aiFlyLateralFrequency");
			aiFlyLateralAmplitude = s.SerializeObject<Angle>(aiFlyLateralAmplitude, name: "aiFlyLateralAmplitude");
			aiFlyPitchFrequency = s.Serialize<float>(aiFlyPitchFrequency, name: "aiFlyPitchFrequency");
			aiFlyPitchAmplitude = s.SerializeObject<Angle>(aiFlyPitchAmplitude, name: "aiFlyPitchAmplitude");
			aiFlyKeepDirDuration = s.Serialize<float>(aiFlyKeepDirDuration, name: "aiFlyKeepDirDuration");
			aiFlyKeepDirTransitionDuration = s.Serialize<float>(aiFlyKeepDirTransitionDuration, name: "aiFlyKeepDirTransitionDuration");
			aiFlyPostKeepDirLifetime = s.Serialize<float>(aiFlyPostKeepDirLifetime, name: "aiFlyPostKeepDirLifetime");
			aiFlyNoMovementLifeTime = s.Serialize<float>(aiFlyNoMovementLifeTime, name: "aiFlyNoMovementLifeTime");
			aiFlyNoMovementEpsilon = s.Serialize<float>(aiFlyNoMovementEpsilon, name: "aiFlyNoMovementEpsilon");
		}
		public override uint? ClassCRC => 0x6E42C62F;
	}
}

