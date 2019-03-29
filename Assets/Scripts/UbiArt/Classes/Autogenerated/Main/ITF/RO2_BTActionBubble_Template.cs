using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionBubble_Template : BTAction_Template {
		[Serialize("anim"                             )] public StringID anim;
		[Serialize("animSwell"                        )] public StringID animSwell;
		[Serialize("fx"                               )] public Path fx;
		[Serialize("spawnOnMarker"                    )] public bool spawnOnMarker;
		[Serialize("floatTime"                        )] public float floatTime;
		[Serialize("floatForce"                       )] public float floatForce;
		[Serialize("sinkForce"                        )] public float sinkForce;
		[Serialize("floatAngleFrequency"              )] public float floatAngleFrequency;
		[Serialize("floatAngleOffset"                 )] public Angle floatAngleOffset;
		[Serialize("floatAirFrictionMultiplier"       )] public float floatAirFrictionMultiplier;
		[Serialize("hitForce"                         )] public float hitForce;
		[Serialize("avoidanceForce"                   )] public float avoidanceForce;
		[Serialize("avoidanceRadius"                  )] public float avoidanceRadius;
		[Serialize("minFloatSpeed"                    )] public float minFloatSpeed;
		[Serialize("maxFloatSpeed"                    )] public float maxFloatSpeed;
		[Serialize("minFloatExtraSpeed"               )] public float minFloatExtraSpeed;
		[Serialize("maxFloatExtraSpeed"               )] public float maxFloatExtraSpeed;
		[Serialize("minSinkSpeed"                     )] public float minSinkSpeed;
		[Serialize("maxSinkSpeed"                     )] public float maxSinkSpeed;
		[Serialize("minXSpeed"                        )] public float minXSpeed;
		[Serialize("maxXSpeed"                        )] public float maxXSpeed;
		[Serialize("floatForceTime"                   )] public float floatForceTime;
		[Serialize("softCollisionRadiusMultiplier"    )] public float softCollisionRadiusMultiplier;
		[Serialize("squashPenetrationRadius"          )] public float squashPenetrationRadius;
		[Serialize("usePhysRadiusAsSoftCollRadius"    )] public bool usePhysRadiusAsSoftCollRadius;
		[Serialize("explodeOnPlayer"                  )] public bool explodeOnPlayer;
		[Serialize("floatForceX"                      )] public float floatForceX;
		[Serialize("explosionFeedBackTime"            )] public float explosionFeedBackTime;
		[Serialize("explosionFeedBackFreq"            )] public float explosionFeedBackFreq;
		[Serialize("explosionFeedBackAmplitude"       )] public float explosionFeedBackAmplitude;
		[Serialize("floatForceExtraTime"              )] public float floatForceExtraTime;
		[Serialize("pedestalMaxUserCount"             )] public uint pedestalMaxUserCount;
		[Serialize("pedestalOffset"                   )] public float pedestalOffset;
		[Serialize("checkWater"                       )] public bool checkWater;
		[Serialize("supportedActorInvincibilityTimer" )] public float supportedActorInvincibilityTimer;
		[Serialize("waitDurationBeforeStimPossibility")] public float waitDurationBeforeStimPossibility;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(animSwell));
			SerializeField(s, nameof(fx));
			SerializeField(s, nameof(spawnOnMarker));
			SerializeField(s, nameof(floatTime));
			SerializeField(s, nameof(floatForce));
			SerializeField(s, nameof(sinkForce));
			SerializeField(s, nameof(floatAngleFrequency));
			SerializeField(s, nameof(floatAngleOffset));
			SerializeField(s, nameof(floatAirFrictionMultiplier));
			SerializeField(s, nameof(hitForce));
			SerializeField(s, nameof(avoidanceForce));
			SerializeField(s, nameof(avoidanceRadius));
			SerializeField(s, nameof(minFloatSpeed));
			SerializeField(s, nameof(maxFloatSpeed));
			SerializeField(s, nameof(minFloatExtraSpeed));
			SerializeField(s, nameof(maxFloatExtraSpeed));
			SerializeField(s, nameof(minSinkSpeed));
			SerializeField(s, nameof(maxSinkSpeed));
			SerializeField(s, nameof(minXSpeed));
			SerializeField(s, nameof(maxXSpeed));
			SerializeField(s, nameof(floatForceTime));
			SerializeField(s, nameof(softCollisionRadiusMultiplier));
			SerializeField(s, nameof(squashPenetrationRadius));
			SerializeField(s, nameof(usePhysRadiusAsSoftCollRadius));
			SerializeField(s, nameof(explodeOnPlayer));
			SerializeField(s, nameof(floatForceX));
			SerializeField(s, nameof(explosionFeedBackTime));
			SerializeField(s, nameof(explosionFeedBackFreq));
			SerializeField(s, nameof(explosionFeedBackAmplitude));
			SerializeField(s, nameof(floatForceExtraTime));
			SerializeField(s, nameof(pedestalMaxUserCount));
			SerializeField(s, nameof(pedestalOffset));
			SerializeField(s, nameof(checkWater));
			SerializeField(s, nameof(supportedActorInvincibilityTimer));
			SerializeField(s, nameof(waitDurationBeforeStimPossibility));
		}
		public override uint? ClassCRC => 0x3A9B7E49;
	}
}

