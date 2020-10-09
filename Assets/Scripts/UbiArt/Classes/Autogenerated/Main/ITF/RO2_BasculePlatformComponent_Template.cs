using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BasculePlatformComponent_Template : ActorComponent_Template {
		public StringID animPivotBone;
		public StringID animAddInput;
		public Angle animMaxAngle;
		public float stiff;
		public float damp;
		public float weightToAngle;
		public Angle maxAngle;
		public float weightMultiplier;
		public float forceMultiplier;
		public float crushMultiplier;
		public StringID onStartRotatingFX;
		public StringID rotatingClockwiseFX;
		public StringID rotatingAntiClockwiseFX;
		public StringID onStopRotatingFX;
		public Angle playStopFXDeltaAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animPivotBone = s.SerializeObject<StringID>(animPivotBone, name: "animPivotBone");
			animAddInput = s.SerializeObject<StringID>(animAddInput, name: "animAddInput");
			animMaxAngle = s.SerializeObject<Angle>(animMaxAngle, name: "animMaxAngle");
			stiff = s.Serialize<float>(stiff, name: "stiff");
			damp = s.Serialize<float>(damp, name: "damp");
			weightToAngle = s.Serialize<float>(weightToAngle, name: "weightToAngle");
			maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
			weightMultiplier = s.Serialize<float>(weightMultiplier, name: "weightMultiplier");
			forceMultiplier = s.Serialize<float>(forceMultiplier, name: "forceMultiplier");
			crushMultiplier = s.Serialize<float>(crushMultiplier, name: "crushMultiplier");
			onStartRotatingFX = s.SerializeObject<StringID>(onStartRotatingFX, name: "onStartRotatingFX");
			rotatingClockwiseFX = s.SerializeObject<StringID>(rotatingClockwiseFX, name: "rotatingClockwiseFX");
			rotatingAntiClockwiseFX = s.SerializeObject<StringID>(rotatingAntiClockwiseFX, name: "rotatingAntiClockwiseFX");
			onStopRotatingFX = s.SerializeObject<StringID>(onStopRotatingFX, name: "onStopRotatingFX");
			playStopFXDeltaAngle = s.SerializeObject<Angle>(playStopFXDeltaAngle, name: "playStopFXDeltaAngle");
		}
		public override uint? ClassCRC => 0x13B5B9AC;
	}
}

