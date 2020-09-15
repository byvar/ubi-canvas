using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MusicalGhostComponent_Template : ActorComponent_Template {
		public float minSpeed;
		public float maxSpeed;
		public float randomSpeedMultiplier;
		public float acceleration;
		public AngleAmount minAngularSpeed;
		public AngleAmount maxAngularSpeed;
		public AngleAmount angularAcceleration;
		public float initialSpeedBoostMultiplier;
		public float initialSpeedBoostDuration;
		public float fleeSpeedMultiplier;
		public float fleeZSpeed;
		public float targetChangeTimeMin;
		public float targetChangeTimeMax;
		public float targetAnticipationMultiplier;
		public CList<AABB> targetBoxes;
		public PerlinNoise_Template m_targetOffsetNoise;
		public float targetBoxChangeProbability;
		public StringID regionId;
		public StringID avoidRegionId;
		public float raycastDepth;
		public float goBackToRegionTimeLimit;
		public bool drawDebug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minSpeed = s.Serialize<float>(minSpeed, name: "minSpeed");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			randomSpeedMultiplier = s.Serialize<float>(randomSpeedMultiplier, name: "randomSpeedMultiplier");
			acceleration = s.Serialize<float>(acceleration, name: "acceleration");
			minAngularSpeed = s.SerializeObject<AngleAmount>(minAngularSpeed, name: "minAngularSpeed");
			maxAngularSpeed = s.SerializeObject<AngleAmount>(maxAngularSpeed, name: "maxAngularSpeed");
			angularAcceleration = s.SerializeObject<AngleAmount>(angularAcceleration, name: "angularAcceleration");
			initialSpeedBoostMultiplier = s.Serialize<float>(initialSpeedBoostMultiplier, name: "initialSpeedBoostMultiplier");
			initialSpeedBoostDuration = s.Serialize<float>(initialSpeedBoostDuration, name: "initialSpeedBoostDuration");
			fleeSpeedMultiplier = s.Serialize<float>(fleeSpeedMultiplier, name: "fleeSpeedMultiplier");
			fleeZSpeed = s.Serialize<float>(fleeZSpeed, name: "fleeZSpeed");
			targetChangeTimeMin = s.Serialize<float>(targetChangeTimeMin, name: "targetChangeTimeMin");
			targetChangeTimeMax = s.Serialize<float>(targetChangeTimeMax, name: "targetChangeTimeMax");
			targetAnticipationMultiplier = s.Serialize<float>(targetAnticipationMultiplier, name: "targetAnticipationMultiplier");
			targetBoxes = s.SerializeObject<CList<AABB>>(targetBoxes, name: "targetBoxes");
			m_targetOffsetNoise = s.SerializeObject<PerlinNoise_Template>(m_targetOffsetNoise, name: "m_targetOffsetNoise");
			targetBoxChangeProbability = s.Serialize<float>(targetBoxChangeProbability, name: "targetBoxChangeProbability");
			regionId = s.SerializeObject<StringID>(regionId, name: "regionId");
			avoidRegionId = s.SerializeObject<StringID>(avoidRegionId, name: "avoidRegionId");
			raycastDepth = s.Serialize<float>(raycastDepth, name: "raycastDepth");
			goBackToRegionTimeLimit = s.Serialize<float>(goBackToRegionTimeLimit, name: "goBackToRegionTimeLimit");
			drawDebug = s.Serialize<bool>(drawDebug, name: "drawDebug");
		}
		public override uint? ClassCRC => 0xE5B638C1;
	}
}

