using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_EnemyBTAIComponent_Template : RO2_BTAIComponent_Template {
		public float squashDeathPenetration;
		public float timeFight;
		public bool disabledPhys;
		public bool canSwim;
		public bool stickOnWall;
		public bool immuneDrag;
		public bool dieOnTap;
		public bool isFlying;
		public bool withShield;
		public StringID colShield;
		public StringID colShield2;
		public float timeBlockingContact;
		public bool shieldIsJustAToy;
		public RO2_EnemyBTAIComponent_Template.StiltsDataStruct StiltsData;
		public uint lifePoints;
		public uint hitReward;
		public uint rehitReward;
		public uint deathReward;
		public Path specialRewardActorPath;
		public bool heartReward;
		public bool getHeartRewardIsForAll;
		public bool forwardHitToLinkedActors;
		public float timeBeforeForwardHit;
		public float distMinforSwipe;
		public bool triggerLinkedActorsOnTrigger;
		public float timeBeforeTriggerLinkedActorOnTrigger;
		public bool immuneCrush;
		public bool immuneDangerousPolyline;
		public bool isSplinterCell;
		public bool isSlingShotTarget;
		public float slingShotDetectionRadius;
		public bool immuneToPlayerHits;
		public bool alwaysCheckDangerousPol;
		public float suspendedFreqSinus;
		public Vec2d suspendedForceSinus;
		public bool disabledTweenOnHit;
		public uint nbFreeRehit;
		public bool canChangeColor;
		public bool allowOwnProjectileHit;
		public bool useBumperPolyline;
		public CListO<RO2_HeartShield_Template> heartShieldData;
		public bool AMCheckTouch;
		public EnemyType enemyType;
		public bool isSeasonalEnemy;
		public bool withHat;
		public StringID colHat;
		public float hatBounceMultiplier;
		public float hideTextureDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				squashDeathPenetration = s.Serialize<float>(squashDeathPenetration, name: "squashDeathPenetration");
				timeFight = s.Serialize<float>(timeFight, name: "timeFight");
				disabledPhys = s.Serialize<bool>(disabledPhys, name: "disabledPhys");
				canSwim = s.Serialize<bool>(canSwim, name: "canSwim");
				stickOnWall = s.Serialize<bool>(stickOnWall, name: "stickOnWall");
				immuneDrag = s.Serialize<bool>(immuneDrag, name: "immuneDrag");
				dieOnTap = s.Serialize<bool>(dieOnTap, name: "dieOnTap");
				isFlying = s.Serialize<bool>(isFlying, name: "isFlying");
				withShield = s.Serialize<bool>(withShield, name: "withShield");
				colShield = s.SerializeObject<StringID>(colShield, name: "colShield");
				colShield2 = s.SerializeObject<StringID>(colShield2, name: "colShield2");
				timeBlockingContact = s.Serialize<float>(timeBlockingContact, name: "timeBlockingContact");
				shieldIsJustAToy = s.Serialize<bool>(shieldIsJustAToy, name: "shieldIsJustAToy");
				StiltsData = s.SerializeObject<RO2_EnemyBTAIComponent_Template.StiltsDataStruct>(StiltsData, name: "StiltsData");
				lifePoints = s.Serialize<uint>(lifePoints, name: "lifePoints");
				hitReward = s.Serialize<uint>(hitReward, name: "hitReward");
				rehitReward = s.Serialize<uint>(rehitReward, name: "rehitReward");
				deathReward = s.Serialize<uint>(deathReward, name: "deathReward");
				specialRewardActorPath = s.SerializeObject<Path>(specialRewardActorPath, name: "specialRewardActorPath");
				heartReward = s.Serialize<bool>(heartReward, name: "heartReward");
				getHeartRewardIsForAll = s.Serialize<bool>(getHeartRewardIsForAll, name: "getHeartRewardIsForAll");
				forwardHitToLinkedActors = s.Serialize<bool>(forwardHitToLinkedActors, name: "forwardHitToLinkedActors");
				timeBeforeForwardHit = s.Serialize<float>(timeBeforeForwardHit, name: "timeBeforeForwardHit");
				distMinforSwipe = s.Serialize<float>(distMinforSwipe, name: "distMinforSwipe");
				triggerLinkedActorsOnTrigger = s.Serialize<bool>(triggerLinkedActorsOnTrigger, name: "triggerLinkedActorsOnTrigger");
				timeBeforeTriggerLinkedActorOnTrigger = s.Serialize<float>(timeBeforeTriggerLinkedActorOnTrigger, name: "timeBeforeTriggerLinkedActorOnTrigger");
				immuneCrush = s.Serialize<bool>(immuneCrush, name: "immuneCrush");
				immuneDangerousPolyline = s.Serialize<bool>(immuneDangerousPolyline, name: "immuneDangerousPolyline");
				isSplinterCell = s.Serialize<bool>(isSplinterCell, name: "isSplinterCell");
				isSlingShotTarget = s.Serialize<bool>(isSlingShotTarget, name: "isSlingShotTarget");
				slingShotDetectionRadius = s.Serialize<float>(slingShotDetectionRadius, name: "slingShotDetectionRadius");
				immuneToPlayerHits = s.Serialize<bool>(immuneToPlayerHits, name: "immuneToPlayerHits");
				alwaysCheckDangerousPol = s.Serialize<bool>(alwaysCheckDangerousPol, name: "alwaysCheckDangerousPol");
				suspendedFreqSinus = s.Serialize<float>(suspendedFreqSinus, name: "suspendedFreqSinus");
				suspendedForceSinus = s.SerializeObject<Vec2d>(suspendedForceSinus, name: "suspendedForceSinus");
				disabledTweenOnHit = s.Serialize<bool>(disabledTweenOnHit, name: "disabledTweenOnHit");
				nbFreeRehit = s.Serialize<uint>(nbFreeRehit, name: "nbFreeRehit");
				canChangeColor = s.Serialize<bool>(canChangeColor, name: "canChangeColor");
				allowOwnProjectileHit = s.Serialize<bool>(allowOwnProjectileHit, name: "allowOwnProjectileHit");
				useBumperPolyline = s.Serialize<bool>(useBumperPolyline, name: "useBumperPolyline");
				heartShieldData = s.SerializeObject<CListO<RO2_HeartShield_Template>>(heartShieldData, name: "heartShieldData");
				AMCheckTouch = s.Serialize<bool>(AMCheckTouch, name: "AMCheckTouch");
				hideTextureDuration = s.Serialize<float>(hideTextureDuration, name: "hideTextureDuration");
				enemyType = s.Serialize<EnemyType>(enemyType, name: "enemyType");
			} else {
				squashDeathPenetration = s.Serialize<float>(squashDeathPenetration, name: "squashDeathPenetration");
				timeFight = s.Serialize<float>(timeFight, name: "timeFight");
				disabledPhys = s.Serialize<bool>(disabledPhys, name: "disabledPhys");
				canSwim = s.Serialize<bool>(canSwim, name: "canSwim");
				stickOnWall = s.Serialize<bool>(stickOnWall, name: "stickOnWall");
				immuneDrag = s.Serialize<bool>(immuneDrag, name: "immuneDrag");
				dieOnTap = s.Serialize<bool>(dieOnTap, name: "dieOnTap");
				isFlying = s.Serialize<bool>(isFlying, name: "isFlying");
				withShield = s.Serialize<bool>(withShield, name: "withShield");
				colShield = s.SerializeObject<StringID>(colShield, name: "colShield");
				colShield2 = s.SerializeObject<StringID>(colShield2, name: "colShield2");
				timeBlockingContact = s.Serialize<float>(timeBlockingContact, name: "timeBlockingContact");
				shieldIsJustAToy = s.Serialize<bool>(shieldIsJustAToy, name: "shieldIsJustAToy");
				StiltsData = s.SerializeObject<RO2_EnemyBTAIComponent_Template.StiltsDataStruct>(StiltsData, name: "StiltsData");
				lifePoints = s.Serialize<uint>(lifePoints, name: "lifePoints");
				hitReward = s.Serialize<uint>(hitReward, name: "hitReward");
				rehitReward = s.Serialize<uint>(rehitReward, name: "rehitReward");
				deathReward = s.Serialize<uint>(deathReward, name: "deathReward");
				specialRewardActorPath = s.SerializeObject<Path>(specialRewardActorPath, name: "specialRewardActorPath");
				heartReward = s.Serialize<bool>(heartReward, name: "heartReward");
				getHeartRewardIsForAll = s.Serialize<bool>(getHeartRewardIsForAll, name: "getHeartRewardIsForAll");
				forwardHitToLinkedActors = s.Serialize<bool>(forwardHitToLinkedActors, name: "forwardHitToLinkedActors");
				timeBeforeForwardHit = s.Serialize<float>(timeBeforeForwardHit, name: "timeBeforeForwardHit");
				distMinforSwipe = s.Serialize<float>(distMinforSwipe, name: "distMinforSwipe");
				triggerLinkedActorsOnTrigger = s.Serialize<bool>(triggerLinkedActorsOnTrigger, name: "triggerLinkedActorsOnTrigger");
				timeBeforeTriggerLinkedActorOnTrigger = s.Serialize<float>(timeBeforeTriggerLinkedActorOnTrigger, name: "timeBeforeTriggerLinkedActorOnTrigger");
				immuneCrush = s.Serialize<bool>(immuneCrush, name: "immuneCrush");
				immuneDangerousPolyline = s.Serialize<bool>(immuneDangerousPolyline, name: "immuneDangerousPolyline");
				isSplinterCell = s.Serialize<bool>(isSplinterCell, name: "isSplinterCell");
				isSlingShotTarget = s.Serialize<bool>(isSlingShotTarget, name: "isSlingShotTarget");
				slingShotDetectionRadius = s.Serialize<float>(slingShotDetectionRadius, name: "slingShotDetectionRadius");
				immuneToPlayerHits = s.Serialize<bool>(immuneToPlayerHits, name: "immuneToPlayerHits");
				alwaysCheckDangerousPol = s.Serialize<bool>(alwaysCheckDangerousPol, name: "alwaysCheckDangerousPol");
				suspendedFreqSinus = s.Serialize<float>(suspendedFreqSinus, name: "suspendedFreqSinus");
				suspendedForceSinus = s.SerializeObject<Vec2d>(suspendedForceSinus, name: "suspendedForceSinus");
				disabledTweenOnHit = s.Serialize<bool>(disabledTweenOnHit, name: "disabledTweenOnHit");
				nbFreeRehit = s.Serialize<uint>(nbFreeRehit, name: "nbFreeRehit");
				canChangeColor = s.Serialize<bool>(canChangeColor, name: "canChangeColor");
				allowOwnProjectileHit = s.Serialize<bool>(allowOwnProjectileHit, name: "allowOwnProjectileHit");
				useBumperPolyline = s.Serialize<bool>(useBumperPolyline, name: "useBumperPolyline");
				heartShieldData = s.SerializeObject<CListO<RO2_HeartShield_Template>>(heartShieldData, name: "heartShieldData");
				AMCheckTouch = s.Serialize<bool>(AMCheckTouch, name: "AMCheckTouch");
				enemyType = s.Serialize<EnemyType>(enemyType, name: "enemyType");
				isSeasonalEnemy = s.Serialize<bool>(isSeasonalEnemy, name: "isSeasonalEnemy");
				withHat = s.Serialize<bool>(withHat, name: "withHat");
				colHat = s.SerializeObject<StringID>(colHat, name: "colHat");
				hatBounceMultiplier = s.Serialize<float>(hatBounceMultiplier, name: "hatBounceMultiplier");
			}
		}
		[Games(GameFlags.RA)]
		public partial class StiltsDataStruct : CSerializable {
			public bool used;
			public StringID firstPolyline;
			public StringID secondPolyline;
			public uint polylineTopEdgeIndex;
			public uint polylineTopEdgeIndexFlipped;
			public float polylineTopEdgeDirection;
			public float polylineTopEdgeDirectionFlipped;
			public float totalHeight;
			public float softColCheckDistance;
			public float softColForce;
			public uint startLevel;
			public Vec2d stiltsOriginCenter;
			public StringID phantomShape;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				used = s.Serialize<bool>(used, name: "used");
				firstPolyline = s.SerializeObject<StringID>(firstPolyline, name: "firstPolyline");
				secondPolyline = s.SerializeObject<StringID>(secondPolyline, name: "secondPolyline");
				polylineTopEdgeIndex = s.Serialize<uint>(polylineTopEdgeIndex, name: "polylineTopEdgeIndex");
				polylineTopEdgeIndexFlipped = s.Serialize<uint>(polylineTopEdgeIndexFlipped, name: "polylineTopEdgeIndexFlipped");
				polylineTopEdgeDirection = s.Serialize<float>(polylineTopEdgeDirection, name: "polylineTopEdgeDirection");
				polylineTopEdgeDirectionFlipped = s.Serialize<float>(polylineTopEdgeDirectionFlipped, name: "polylineTopEdgeDirectionFlipped");
				totalHeight = s.Serialize<float>(totalHeight, name: "totalHeight");
				softColCheckDistance = s.Serialize<float>(softColCheckDistance, name: "softColCheckDistance");
				softColForce = s.Serialize<float>(softColForce, name: "softColForce");
				startLevel = s.Serialize<uint>(startLevel, name: "startLevel");
				stiltsOriginCenter = s.SerializeObject<Vec2d>(stiltsOriginCenter, name: "stiltsOriginCenter");
				if (Settings.s.game == Settings.Game.RL) {
					phantomShape = s.SerializeObject<StringID>(phantomShape, name: "phantomShape");
				}
			}
		}
		public enum EnemyType {
			[Serialize("enemyType_None"  )] None = 0,
			[Serialize("enemyType_Toad"  )] Toad = 1,
			[Serialize("enemyType_Turnip")] Turnip = 2,
		}
		public override uint? ClassCRC => 0xF3259B14;
	}
}

