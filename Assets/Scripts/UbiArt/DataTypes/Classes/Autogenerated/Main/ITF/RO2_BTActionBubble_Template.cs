namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionBubble_Template : BTAction_Template {
		public StringID anim;
		public StringID animSwell;
		public Path fx;
		public bool spawnOnMarker = true;
		public float floatTime = 5f;
		public float floatForce = 25f;
		public float sinkForce = 4f;
		public float floatAngleFrequency = 0.2f;
		public Angle floatAngleOffset = 0.08726646f;
		public float floatAirFrictionMultiplier = 20f;
		public float hitForce = 800f;
		public float avoidanceForce = 50f;
		public float avoidanceRadius = 0.7f;
		public float minFloatSpeed = 1f;
		public float maxFloatSpeed = 3f;
		public float minFloatExtraSpeed = 2f;
		public float maxFloatExtraSpeed = 6f;
		public float minSinkSpeed = 1f;
		public float maxSinkSpeed = 3f;
		public float minXSpeed = 1f;
		public float maxXSpeed = 3f;
		public float floatForceTime = 0.5f;
		public float softCollisionRadiusMultiplier = 1f;
		public float squashPenetrationRadius = 0.9f;
		public bool usePhysRadiusAsSoftCollRadius;
		public bool explodeOnPlayer;
		public float floatForceX = 0.5f;
		public float explosionFeedBackTime = 1f;
		public float explosionFeedBackFreq = 10f;
		public float explosionFeedBackAmplitude = 0.5f;
		public float floatForceExtraTime = 1f;
		public uint pedestalMaxUserCount = 4;
		public float pedestalOffset = 1f;
		public bool checkWater = true;
		public float supportedActorInvincibilityTimer = 0.2f;
		public float waitDurationBeforeStimPossibility;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			animSwell = s.SerializeObject<StringID>(animSwell, name: "animSwell");
			fx = s.SerializeObject<Path>(fx, name: "fx");
			spawnOnMarker = s.Serialize<bool>(spawnOnMarker, name: "spawnOnMarker");
			floatTime = s.Serialize<float>(floatTime, name: "floatTime");
			floatForce = s.Serialize<float>(floatForce, name: "floatForce");
			sinkForce = s.Serialize<float>(sinkForce, name: "sinkForce");
			floatAngleFrequency = s.Serialize<float>(floatAngleFrequency, name: "floatAngleFrequency");
			floatAngleOffset = s.SerializeObject<Angle>(floatAngleOffset, name: "floatAngleOffset");
			floatAirFrictionMultiplier = s.Serialize<float>(floatAirFrictionMultiplier, name: "floatAirFrictionMultiplier");
			hitForce = s.Serialize<float>(hitForce, name: "hitForce");
			avoidanceForce = s.Serialize<float>(avoidanceForce, name: "avoidanceForce");
			avoidanceRadius = s.Serialize<float>(avoidanceRadius, name: "avoidanceRadius");
			minFloatSpeed = s.Serialize<float>(minFloatSpeed, name: "minFloatSpeed");
			maxFloatSpeed = s.Serialize<float>(maxFloatSpeed, name: "maxFloatSpeed");
			minFloatExtraSpeed = s.Serialize<float>(minFloatExtraSpeed, name: "minFloatExtraSpeed");
			maxFloatExtraSpeed = s.Serialize<float>(maxFloatExtraSpeed, name: "maxFloatExtraSpeed");
			minSinkSpeed = s.Serialize<float>(minSinkSpeed, name: "minSinkSpeed");
			maxSinkSpeed = s.Serialize<float>(maxSinkSpeed, name: "maxSinkSpeed");
			minXSpeed = s.Serialize<float>(minXSpeed, name: "minXSpeed");
			maxXSpeed = s.Serialize<float>(maxXSpeed, name: "maxXSpeed");
			floatForceTime = s.Serialize<float>(floatForceTime, name: "floatForceTime");
			softCollisionRadiusMultiplier = s.Serialize<float>(softCollisionRadiusMultiplier, name: "softCollisionRadiusMultiplier");
			squashPenetrationRadius = s.Serialize<float>(squashPenetrationRadius, name: "squashPenetrationRadius");
			usePhysRadiusAsSoftCollRadius = s.Serialize<bool>(usePhysRadiusAsSoftCollRadius, name: "usePhysRadiusAsSoftCollRadius");
			explodeOnPlayer = s.Serialize<bool>(explodeOnPlayer, name: "explodeOnPlayer");
			floatForceX = s.Serialize<float>(floatForceX, name: "floatForceX");
			explosionFeedBackTime = s.Serialize<float>(explosionFeedBackTime, name: "explosionFeedBackTime");
			explosionFeedBackFreq = s.Serialize<float>(explosionFeedBackFreq, name: "explosionFeedBackFreq");
			explosionFeedBackAmplitude = s.Serialize<float>(explosionFeedBackAmplitude, name: "explosionFeedBackAmplitude");
			floatForceExtraTime = s.Serialize<float>(floatForceExtraTime, name: "floatForceExtraTime");
			pedestalMaxUserCount = s.Serialize<uint>(pedestalMaxUserCount, name: "pedestalMaxUserCount");
			pedestalOffset = s.Serialize<float>(pedestalOffset, name: "pedestalOffset");
			checkWater = s.Serialize<bool>(checkWater, name: "checkWater");
			supportedActorInvincibilityTimer = s.Serialize<float>(supportedActorInvincibilityTimer, name: "supportedActorInvincibilityTimer");
			waitDurationBeforeStimPossibility = s.Serialize<float>(waitDurationBeforeStimPossibility, name: "waitDurationBeforeStimPossibility");
		}
		public override uint? ClassCRC => 0x3A9B7E49;
	}
}

