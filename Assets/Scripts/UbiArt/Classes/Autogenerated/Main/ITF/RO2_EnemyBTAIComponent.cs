using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_EnemyBTAIComponent : RO2_BTAIComponent {
		public EditableShape shape;
		public Enum_appearType appearType;
		public Enum_appearType2 appearType2;
		public bool useChargeDirect;
		public bool useChargeSpot;
		public bool chargeOnce;
		public bool useTrigger;
		public bool useRoaming;
		public float distRoamingUnderWater;
		public Vec2d distRoamingWhenFlying;
		public bool useNightVision;
		public float limitLeft;
		public float limitRight;
		public bool dashCheckHole;
		public Enum_tortureTypeType tortureTypeType;
		public bool useRangedAttack;
		public int useRangedAttack_RL;
		public uint RA_countBulletBySequence;
		public float RA_timeBetweenBullet;
		public float RA_timeBetweenSequence;
		public bool RA_useAim;
		public float RA_bulletLifeTime;
		public float RA_aimTime;
		public bool parachuteStartRight;
		public bool isFishing;
		public bool sleep;
		public bool useBossCollision;
		public bool isLinkedToForceField;
		public bool useQuickLaunch;
		public bool canTriggerMagnet;
		public bool noUturn;
		public CArrayO<Angle> RA_anglesNoAim;
		public bool isDead;
		public bool quickLaunchUsed;
		public uint lifePoints;
		public uint nbTickleRewarded;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					shape = s.SerializeObject<EditableShape>(shape, name: "shape");
					appearType2 = s.Serialize<Enum_appearType2>(appearType2, name: "appearType2");
					useChargeDirect = s.Serialize<bool>(useChargeDirect, name: "useChargeDirect");
					useChargeSpot = s.Serialize<bool>(useChargeSpot, name: "useChargeSpot");
					chargeOnce = s.Serialize<bool>(chargeOnce, name: "chargeOnce");
					useTrigger = s.Serialize<bool>(useTrigger, name: "useTrigger");
					useRoaming = s.Serialize<bool>(useRoaming, name: "useRoaming");
					distRoamingUnderWater = s.Serialize<float>(distRoamingUnderWater, name: "distRoamingUnderWater");
					distRoamingWhenFlying = s.SerializeObject<Vec2d>(distRoamingWhenFlying, name: "distRoamingWhenFlying");
					useNightVision = s.Serialize<bool>(useNightVision, name: "useNightVision");
					limitLeft = s.Serialize<float>(limitLeft, name: "limitLeft");
					limitRight = s.Serialize<float>(limitRight, name: "limitRight");
					tortureTypeType = s.Serialize<Enum_tortureTypeType>(tortureTypeType, name: "tortureTypeType");
					useRangedAttack_RL = s.Serialize<int>(useRangedAttack_RL, name: "useRangedAttack");
					RA_countBulletBySequence = s.Serialize<uint>(RA_countBulletBySequence, name: "RA_countBulletBySequence");
					RA_timeBetweenBullet = s.Serialize<float>(RA_timeBetweenBullet, name: "RA_timeBetweenBullet");
					RA_timeBetweenSequence = s.Serialize<float>(RA_timeBetweenSequence, name: "RA_timeBetweenSequence");
					RA_useAim = s.Serialize<bool>(RA_useAim, name: "RA_useAim");
					RA_anglesNoAim = s.SerializeObject<CArrayO<Angle>>(RA_anglesNoAim, name: "RA_anglesNoAim");
					parachuteStartRight = s.Serialize<bool>(parachuteStartRight, name: "parachuteStartRight");
					isFishing = s.Serialize<bool>(isFishing, name: "isFishing");
					sleep = s.Serialize<bool>(sleep, name: "sleep");
					useBossCollision = s.Serialize<bool>(useBossCollision, name: "useBossCollision");
					isLinkedToForceField = s.Serialize<bool>(isLinkedToForceField, name: "isLinkedToForceField");
					useQuickLaunch = s.Serialize<bool>(useQuickLaunch, name: "useQuickLaunch");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					isDead = s.Serialize<bool>(isDead, name: "isDead");
					quickLaunchUsed = s.Serialize<bool>(quickLaunchUsed, name: "quickLaunchUsed");
					lifePoints = s.Serialize<uint>(lifePoints, name: "lifePoints");
					nbTickleRewarded = s.Serialize<uint>(nbTickleRewarded, name: "nbTickleRewarded");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					shape = s.SerializeObject<EditableShape>(shape, name: "shape");
					appearType = s.Serialize<Enum_appearType>(appearType, name: "appearType");
					useChargeDirect = s.Serialize<bool>(useChargeDirect, name: "useChargeDirect");
					useChargeSpot = s.Serialize<bool>(useChargeSpot, name: "useChargeSpot");
					chargeOnce = s.Serialize<bool>(chargeOnce, name: "chargeOnce");
					useTrigger = s.Serialize<bool>(useTrigger, name: "useTrigger");
					useRoaming = s.Serialize<bool>(useRoaming, name: "useRoaming");
					distRoamingUnderWater = s.Serialize<float>(distRoamingUnderWater, name: "distRoamingUnderWater");
					distRoamingWhenFlying = s.SerializeObject<Vec2d>(distRoamingWhenFlying, name: "distRoamingWhenFlying");
					useNightVision = s.Serialize<bool>(useNightVision, name: "useNightVision");
					limitLeft = s.Serialize<float>(limitLeft, name: "limitLeft");
					limitRight = s.Serialize<float>(limitRight, name: "limitRight");
					dashCheckHole = s.Serialize<bool>(dashCheckHole, name: "dashCheckHole");
					tortureTypeType = s.Serialize<Enum_tortureTypeType>(tortureTypeType, name: "tortureTypeType");
					useRangedAttack = s.Serialize<bool>(useRangedAttack, name: "useRangedAttack");
					RA_countBulletBySequence = s.Serialize<uint>(RA_countBulletBySequence, name: "RA_countBulletBySequence");
					RA_timeBetweenBullet = s.Serialize<float>(RA_timeBetweenBullet, name: "RA_timeBetweenBullet");
					RA_timeBetweenSequence = s.Serialize<float>(RA_timeBetweenSequence, name: "RA_timeBetweenSequence");
					RA_useAim = s.Serialize<bool>(RA_useAim, name: "RA_useAim");
					RA_bulletLifeTime = s.Serialize<float>(RA_bulletLifeTime, name: "RA_bulletLifeTime");
					RA_aimTime = s.Serialize<float>(RA_aimTime, name: "RA_aimTime");
					parachuteStartRight = s.Serialize<bool>(parachuteStartRight, name: "parachuteStartRight");
					isFishing = s.Serialize<bool>(isFishing, name: "isFishing");
					sleep = s.Serialize<bool>(sleep, name: "sleep");
					useBossCollision = s.Serialize<bool>(useBossCollision, name: "useBossCollision");
					isLinkedToForceField = s.Serialize<bool>(isLinkedToForceField, name: "isLinkedToForceField");
					useQuickLaunch = s.Serialize<bool>(useQuickLaunch, name: "useQuickLaunch");
					canTriggerMagnet = s.Serialize<bool>(canTriggerMagnet, name: "canTriggerMagnet");
					noUturn = s.Serialize<bool>(noUturn, name: "noUturn");
					RA_anglesNoAim = s.SerializeObject<CArrayO<Angle>>(RA_anglesNoAim, name: "RA_anglesNoAim");
					RA_anglesNoAim = s.SerializeObject<CArrayO<Angle>>(RA_anglesNoAim, name: "RA_anglesNoAim");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					isDead = s.Serialize<bool>(isDead, name: "isDead");
					quickLaunchUsed = s.Serialize<bool>(quickLaunchUsed, name: "quickLaunchUsed");
					lifePoints = s.Serialize<uint>(lifePoints, name: "lifePoints");
					nbTickleRewarded = s.Serialize<uint>(nbTickleRewarded, name: "nbTickleRewarded");
				}
			}
		}
		public enum Enum_appearType {
			[Serialize("Direct"           )] Direct = 3,
			[Serialize("FromGround"       )] FromGround = 0,
			[Serialize("Parachute"        )] Parachute = 1,
			[Serialize("JumpFromZ"        )] JumpFromZ = 2,
			[Serialize("JumpFromZ_Ninja"  )] JumpFromZ_Ninja = 4,
			[Serialize("JumpFromZ_Ladders")] JumpFromZ_Ladders = 5,
			[Serialize("Fall"             )] Fall = 6,
			[Serialize("Splinter"         )] Splinter = 7,
			[Serialize("FromAbove"        )] FromAbove = 8,
			[Serialize("Basket"           )] Basket = 9,
			[Serialize("Rope"             )] Rope = 10,
		}
		public enum Enum_tortureTypeType {
			[Serialize("None"           )] None = 0,
			[Serialize("HitHeadOnGround")] HitHeadOnGround = 1,
			[Serialize("JumpOnVictim"   )] JumpOnVictim = 2,
		}
		public enum Enum_appearType2 {
			[Serialize("Direct"           )] Direct = 3,
			[Serialize("FromGround"       )] FromGround = 0,
			[Serialize("Parachute"        )] Parachute = 1,
			[Serialize("JumpFromZ"        )] JumpFromZ = 2,
			[Serialize("JumpFromZ_Ninja"  )] JumpFromZ_Ninja = 4,
			[Serialize("JumpFromZ_Ladders")] JumpFromZ_Ladders = 5,
			[Serialize("Fall"             )] Fall = 6,
			[Serialize("Splinter"         )] Splinter = 7,
			[Serialize("FromAbove"        )] FromAbove = 8,
		}
		public override uint? ClassCRC => 0x8DDACC87;
	}
}

