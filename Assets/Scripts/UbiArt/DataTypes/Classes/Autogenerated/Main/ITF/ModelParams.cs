namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ModelParams : CSerializable {
		public int id;
		public float targetRadius;
		public float enemyDetectionRadius;
		public float maxSpeed;
		public float maxSpeedThreatened;
		public float predictionFactor;
		public float maxPredicitionDistance;
		public float offsetRadius;
		public float separationRadius;
		public float separationForce;
		public float playerSeparationRadius;
		public float playerSeparationForce;
		public float groundSeparationRadius;
		public float groundSeparationForce;
		public float minWaitTime;
		public float maxWaitTime;
		public bool flock;
		public float linearBlendFactor;
		public float linearMidBlendFactor;
		public float linearTolerance;
		public StringID onHitFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			id = s.Serialize<int>(id, name: "id");
			targetRadius = s.Serialize<float>(targetRadius, name: "targetRadius");
			enemyDetectionRadius = s.Serialize<float>(enemyDetectionRadius, name: "enemyDetectionRadius");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			maxSpeedThreatened = s.Serialize<float>(maxSpeedThreatened, name: "maxSpeedThreatened");
			predictionFactor = s.Serialize<float>(predictionFactor, name: "predictionFactor");
			maxPredicitionDistance = s.Serialize<float>(maxPredicitionDistance, name: "maxPredicitionDistance");
			offsetRadius = s.Serialize<float>(offsetRadius, name: "offsetRadius");
			separationRadius = s.Serialize<float>(separationRadius, name: "separationRadius");
			separationForce = s.Serialize<float>(separationForce, name: "separationForce");
			playerSeparationRadius = s.Serialize<float>(playerSeparationRadius, name: "playerSeparationRadius");
			playerSeparationForce = s.Serialize<float>(playerSeparationForce, name: "playerSeparationForce");
			groundSeparationRadius = s.Serialize<float>(groundSeparationRadius, name: "groundSeparationRadius");
			groundSeparationForce = s.Serialize<float>(groundSeparationForce, name: "groundSeparationForce");
			minWaitTime = s.Serialize<float>(minWaitTime, name: "minWaitTime");
			maxWaitTime = s.Serialize<float>(maxWaitTime, name: "maxWaitTime");
			flock = s.Serialize<bool>(flock, name: "flock");
			linearBlendFactor = s.Serialize<float>(linearBlendFactor, name: "linearBlendFactor");
			linearMidBlendFactor = s.Serialize<float>(linearMidBlendFactor, name: "linearMidBlendFactor");
			linearTolerance = s.Serialize<float>(linearTolerance, name: "linearTolerance");
			onHitFX = s.SerializeObject<StringID>(onHitFX, name: "onHitFX");
		}
	}
}

