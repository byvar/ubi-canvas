using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_SeekingJellyfishAIComponent_Template : CSerializable {
		[Serialize("minSpeed"                    )] public float minSpeed;
		[Serialize("maxSpeed"                    )] public float maxSpeed;
		[Serialize("acceleration"                )] public float acceleration;
		[Serialize("minAngularSpeed"             )] public AngleAmount minAngularSpeed;
		[Serialize("maxAngularSpeed"             )] public AngleAmount maxAngularSpeed;
		[Serialize("angularAcceleration"         )] public AngleAmount angularAcceleration;
		[Serialize("initialSpeedBoostMultiplier" )] public float initialSpeedBoostMultiplier;
		[Serialize("initialSpeedBoostDuration"   )] public float initialSpeedBoostDuration;
		[Serialize("fleeSpeedMultiplier"         )] public float fleeSpeedMultiplier;
		[Serialize("fleeZSpeed"                  )] public float fleeZSpeed;
		[Serialize("targetChangeTimeMin"         )] public float targetChangeTimeMin;
		[Serialize("targetChangeTimeMax"         )] public float targetChangeTimeMax;
		[Serialize("targetAnticipationMultiplier")] public float targetAnticipationMultiplier;
		[Serialize("regionId"                    )] public StringID regionId;
		[Serialize("avoidRegionId"               )] public StringID avoidRegionId;
		[Serialize("raycastDepth"                )] public float raycastDepth;
		[Serialize("goBackToRegionTimeLimit"     )] public float goBackToRegionTimeLimit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minSpeed));
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(acceleration));
			SerializeField(s, nameof(minAngularSpeed));
			SerializeField(s, nameof(maxAngularSpeed));
			SerializeField(s, nameof(angularAcceleration));
			SerializeField(s, nameof(initialSpeedBoostMultiplier));
			SerializeField(s, nameof(initialSpeedBoostDuration));
			SerializeField(s, nameof(fleeSpeedMultiplier));
			SerializeField(s, nameof(fleeZSpeed));
			SerializeField(s, nameof(targetChangeTimeMin));
			SerializeField(s, nameof(targetChangeTimeMax));
			SerializeField(s, nameof(targetAnticipationMultiplier));
			SerializeField(s, nameof(regionId));
			SerializeField(s, nameof(avoidRegionId));
			SerializeField(s, nameof(raycastDepth));
			SerializeField(s, nameof(goBackToRegionTimeLimit));
		}
		public override uint? ClassCRC => 0x14BE43C0;
	}
}

