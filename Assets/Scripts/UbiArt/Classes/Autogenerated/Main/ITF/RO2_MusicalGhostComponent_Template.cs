using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_MusicalGhostComponent_Template : ActorComponent_Template {
		[Serialize("minSpeed"                    )] public float minSpeed;
		[Serialize("maxSpeed"                    )] public float maxSpeed;
		[Serialize("randomSpeedMultiplier"       )] public float randomSpeedMultiplier;
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
		[Serialize("targetBoxes"                 )] public CList<AABB> targetBoxes;
		[Serialize("m_targetOffsetNoise"         )] public PerlinNoise_Template m_targetOffsetNoise;
		[Serialize("targetBoxChangeProbability"  )] public float targetBoxChangeProbability;
		[Serialize("regionId"                    )] public StringID regionId;
		[Serialize("avoidRegionId"               )] public StringID avoidRegionId;
		[Serialize("raycastDepth"                )] public float raycastDepth;
		[Serialize("goBackToRegionTimeLimit"     )] public float goBackToRegionTimeLimit;
		[Serialize("drawDebug"                   )] public bool drawDebug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minSpeed));
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(randomSpeedMultiplier));
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
			SerializeField(s, nameof(targetBoxes));
			SerializeField(s, nameof(m_targetOffsetNoise));
			SerializeField(s, nameof(targetBoxChangeProbability));
			SerializeField(s, nameof(regionId));
			SerializeField(s, nameof(avoidRegionId));
			SerializeField(s, nameof(raycastDepth));
			SerializeField(s, nameof(goBackToRegionTimeLimit));
			SerializeField(s, nameof(drawDebug));
		}
		public override uint? ClassCRC => 0xE5B638C1;
	}
}

