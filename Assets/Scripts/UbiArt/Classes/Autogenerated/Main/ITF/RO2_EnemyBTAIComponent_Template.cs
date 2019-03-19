using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_EnemyBTAIComponent_Template : RO2_BTAIComponent_Template {
		[Serialize("squashDeathPenetration"               )] public float squashDeathPenetration;
		[Serialize("timeFight"                            )] public float timeFight;
		[Serialize("disabledPhys"                         )] public bool disabledPhys;
		[Serialize("canSwim"                              )] public bool canSwim;
		[Serialize("stickOnWall"                          )] public bool stickOnWall;
		[Serialize("immuneDrag"                           )] public bool immuneDrag;
		[Serialize("dieOnTap"                             )] public bool dieOnTap;
		[Serialize("isFlying"                             )] public bool isFlying;
		[Serialize("withShield"                           )] public bool withShield;
		[Serialize("colShield"                            )] public StringID colShield;
		[Serialize("colShield2"                           )] public StringID colShield2;
		[Serialize("timeBlockingContact"                  )] public float timeBlockingContact;
		[Serialize("shieldIsJustAToy"                     )] public bool shieldIsJustAToy;
		[Serialize("StiltsData"                           )] public RO2_EnemyBTAIComponent_Template.StiltsDataStruct StiltsData;
		[Serialize("lifePoints"                           )] public uint lifePoints;
		[Serialize("hitReward"                            )] public uint hitReward;
		[Serialize("rehitReward"                          )] public uint rehitReward;
		[Serialize("deathReward"                          )] public uint deathReward;
		[Serialize("specialRewardActorPath"               )] public Path specialRewardActorPath;
		[Serialize("heartReward"                          )] public bool heartReward;
		[Serialize("getHeartRewardIsForAll"               )] public bool getHeartRewardIsForAll;
		[Serialize("forwardHitToLinkedActors"             )] public bool forwardHitToLinkedActors;
		[Serialize("timeBeforeForwardHit"                 )] public float timeBeforeForwardHit;
		[Serialize("distMinforSwipe"                      )] public float distMinforSwipe;
		[Serialize("triggerLinkedActorsOnTrigger"         )] public bool triggerLinkedActorsOnTrigger;
		[Serialize("timeBeforeTriggerLinkedActorOnTrigger")] public float timeBeforeTriggerLinkedActorOnTrigger;
		[Serialize("immuneCrush"                          )] public bool immuneCrush;
		[Serialize("immuneDangerousPolyline"              )] public bool immuneDangerousPolyline;
		[Serialize("isSplinterCell"                       )] public bool isSplinterCell;
		[Serialize("isSlingShotTarget"                    )] public bool isSlingShotTarget;
		[Serialize("slingShotDetectionRadius"             )] public float slingShotDetectionRadius;
		[Serialize("immuneToPlayerHits"                   )] public bool immuneToPlayerHits;
		[Serialize("alwaysCheckDangerousPol"              )] public bool alwaysCheckDangerousPol;
		[Serialize("suspendedFreqSinus"                   )] public float suspendedFreqSinus;
		[Serialize("suspendedForceSinus"                  )] public Vector2 suspendedForceSinus;
		[Serialize("disabledTweenOnHit"                   )] public bool disabledTweenOnHit;
		[Serialize("nbFreeRehit"                          )] public uint nbFreeRehit;
		[Serialize("canChangeColor"                       )] public bool canChangeColor;
		[Serialize("allowOwnProjectileHit"                )] public bool allowOwnProjectileHit;
		[Serialize("useBumperPolyline"                    )] public bool useBumperPolyline;
		[Serialize("heartShieldData"                      )] public CList<RO2_HeartShield_Template> heartShieldData;
		[Serialize("AMCheckTouch"                         )] public bool AMCheckTouch;
		[Serialize("enemyType"                            )] public enemyType enemyType;
		[Serialize("isSeasonalEnemy"                      )] public bool isSeasonalEnemy;
		[Serialize("withHat"                              )] public bool withHat;
		[Serialize("colHat"                               )] public StringID colHat;
		[Serialize("hatBounceMultiplier"                  )] public float hatBounceMultiplier;
		[Serialize("hideTextureDuration"                  )] public float hideTextureDuration;
		[Serialize("enemyType"                            )] public Enum_enemyType enemyType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(squashDeathPenetration));
				SerializeField(s, nameof(timeFight));
				SerializeField(s, nameof(disabledPhys));
				SerializeField(s, nameof(canSwim));
				SerializeField(s, nameof(stickOnWall));
				SerializeField(s, nameof(immuneDrag));
				SerializeField(s, nameof(dieOnTap));
				SerializeField(s, nameof(isFlying));
				SerializeField(s, nameof(withShield));
				SerializeField(s, nameof(colShield));
				SerializeField(s, nameof(colShield2));
				SerializeField(s, nameof(timeBlockingContact));
				SerializeField(s, nameof(shieldIsJustAToy));
				SerializeField(s, nameof(StiltsData));
				SerializeField(s, nameof(lifePoints));
				SerializeField(s, nameof(hitReward));
				SerializeField(s, nameof(rehitReward));
				SerializeField(s, nameof(deathReward));
				SerializeField(s, nameof(specialRewardActorPath));
				SerializeField(s, nameof(heartReward));
				SerializeField(s, nameof(getHeartRewardIsForAll));
				SerializeField(s, nameof(forwardHitToLinkedActors));
				SerializeField(s, nameof(timeBeforeForwardHit));
				SerializeField(s, nameof(distMinforSwipe));
				SerializeField(s, nameof(triggerLinkedActorsOnTrigger));
				SerializeField(s, nameof(timeBeforeTriggerLinkedActorOnTrigger));
				SerializeField(s, nameof(immuneCrush));
				SerializeField(s, nameof(immuneDangerousPolyline));
				SerializeField(s, nameof(isSplinterCell));
				SerializeField(s, nameof(isSlingShotTarget));
				SerializeField(s, nameof(slingShotDetectionRadius));
				SerializeField(s, nameof(immuneToPlayerHits));
				SerializeField(s, nameof(alwaysCheckDangerousPol));
				SerializeField(s, nameof(suspendedFreqSinus));
				SerializeField(s, nameof(suspendedForceSinus));
				SerializeField(s, nameof(disabledTweenOnHit));
				SerializeField(s, nameof(nbFreeRehit));
				SerializeField(s, nameof(canChangeColor));
				SerializeField(s, nameof(allowOwnProjectileHit));
				SerializeField(s, nameof(useBumperPolyline));
				SerializeField(s, nameof(heartShieldData));
				SerializeField(s, nameof(AMCheckTouch));
				SerializeField(s, nameof(hideTextureDuration));
				SerializeField(s, nameof(enemyType));
			} else {
				SerializeField(s, nameof(squashDeathPenetration));
				SerializeField(s, nameof(timeFight));
				SerializeField(s, nameof(disabledPhys));
				SerializeField(s, nameof(canSwim));
				SerializeField(s, nameof(stickOnWall));
				SerializeField(s, nameof(immuneDrag));
				SerializeField(s, nameof(dieOnTap));
				SerializeField(s, nameof(isFlying));
				SerializeField(s, nameof(withShield));
				SerializeField(s, nameof(colShield));
				SerializeField(s, nameof(colShield2));
				SerializeField(s, nameof(timeBlockingContact));
				SerializeField(s, nameof(shieldIsJustAToy));
				SerializeField(s, nameof(StiltsData));
				SerializeField(s, nameof(lifePoints));
				SerializeField(s, nameof(hitReward));
				SerializeField(s, nameof(rehitReward));
				SerializeField(s, nameof(deathReward));
				SerializeField(s, nameof(specialRewardActorPath));
				SerializeField(s, nameof(heartReward));
				SerializeField(s, nameof(getHeartRewardIsForAll));
				SerializeField(s, nameof(forwardHitToLinkedActors));
				SerializeField(s, nameof(timeBeforeForwardHit));
				SerializeField(s, nameof(distMinforSwipe));
				SerializeField(s, nameof(triggerLinkedActorsOnTrigger));
				SerializeField(s, nameof(timeBeforeTriggerLinkedActorOnTrigger));
				SerializeField(s, nameof(immuneCrush));
				SerializeField(s, nameof(immuneDangerousPolyline));
				SerializeField(s, nameof(isSplinterCell));
				SerializeField(s, nameof(isSlingShotTarget));
				SerializeField(s, nameof(slingShotDetectionRadius));
				SerializeField(s, nameof(immuneToPlayerHits));
				SerializeField(s, nameof(alwaysCheckDangerousPol));
				SerializeField(s, nameof(suspendedFreqSinus));
				SerializeField(s, nameof(suspendedForceSinus));
				SerializeField(s, nameof(disabledTweenOnHit));
				SerializeField(s, nameof(nbFreeRehit));
				SerializeField(s, nameof(canChangeColor));
				SerializeField(s, nameof(allowOwnProjectileHit));
				SerializeField(s, nameof(useBumperPolyline));
				SerializeField(s, nameof(heartShieldData));
				SerializeField(s, nameof(AMCheckTouch));
				SerializeField(s, nameof(enemyType));
				SerializeField(s, nameof(isSeasonalEnemy));
				SerializeField(s, nameof(withHat));
				SerializeField(s, nameof(colHat));
				SerializeField(s, nameof(hatBounceMultiplier));
			}
		}
		[Games(GameFlags.RA)]
		public partial class StiltsDataStruct : CSerializable {
			[Serialize("used"                           )] public bool used;
			[Serialize("firstPolyline"                  )] public StringID firstPolyline;
			[Serialize("secondPolyline"                 )] public StringID secondPolyline;
			[Serialize("polylineTopEdgeIndex"           )] public uint polylineTopEdgeIndex;
			[Serialize("polylineTopEdgeIndexFlipped"    )] public uint polylineTopEdgeIndexFlipped;
			[Serialize("polylineTopEdgeDirection"       )] public float polylineTopEdgeDirection;
			[Serialize("polylineTopEdgeDirectionFlipped")] public float polylineTopEdgeDirectionFlipped;
			[Serialize("totalHeight"                    )] public float totalHeight;
			[Serialize("softColCheckDistance"           )] public float softColCheckDistance;
			[Serialize("softColForce"                   )] public float softColForce;
			[Serialize("startLevel"                     )] public uint startLevel;
			[Serialize("stiltsOriginCenter"             )] public Vector2 stiltsOriginCenter;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(used));
				SerializeField(s, nameof(firstPolyline));
				SerializeField(s, nameof(secondPolyline));
				SerializeField(s, nameof(polylineTopEdgeIndex));
				SerializeField(s, nameof(polylineTopEdgeIndexFlipped));
				SerializeField(s, nameof(polylineTopEdgeDirection));
				SerializeField(s, nameof(polylineTopEdgeDirectionFlipped));
				SerializeField(s, nameof(totalHeight));
				SerializeField(s, nameof(softColCheckDistance));
				SerializeField(s, nameof(softColForce));
				SerializeField(s, nameof(startLevel));
				SerializeField(s, nameof(stiltsOriginCenter));
			}
		}
		public enum enemyType {
			[Serialize("enemyType_None"  )] None = 0,
			[Serialize("enemyType_Toad"  )] Toad = 1,
			[Serialize("enemyType_Turnip")] Turnip = 2,
		}
		public enum Enum_enemyType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xF3259B14;
	}
}

