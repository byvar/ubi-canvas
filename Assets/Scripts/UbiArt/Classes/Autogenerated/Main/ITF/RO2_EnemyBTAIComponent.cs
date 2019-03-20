using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_EnemyBTAIComponent : RO2_BTAIComponent {
		[Serialize("shape"                   )] public EditableShape shape;
		[Serialize("appearType"              )] public Enum_appearType appearType;
		[Serialize("appearType"              )] public Enum_appearType2 appearType2;
		[Serialize("useChargeDirect"         )] public bool useChargeDirect;
		[Serialize("useChargeSpot"           )] public bool useChargeSpot;
		[Serialize("chargeOnce"              )] public bool chargeOnce;
		[Serialize("useTrigger"              )] public bool useTrigger;
		[Serialize("useRoaming"              )] public bool useRoaming;
		[Serialize("distRoamingUnderWater"   )] public float distRoamingUnderWater;
		[Serialize("distRoamingWhenFlying"   )] public Vector2 distRoamingWhenFlying;
		[Serialize("useNightVision"          )] public bool useNightVision;
		[Serialize("limitLeft"               )] public float limitLeft;
		[Serialize("limitRight"              )] public float limitRight;
		[Serialize("dashCheckHole"           )] public bool dashCheckHole;
		[Serialize("tortureTypeType"         )] public Enum_tortureTypeType tortureTypeType;
		[Serialize("useRangedAttack"         )] public bool useRangedAttack;
		[Serialize("RA_countBulletBySequence")] public uint RA_countBulletBySequence;
		[Serialize("RA_timeBetweenBullet"    )] public float RA_timeBetweenBullet;
		[Serialize("RA_timeBetweenSequence"  )] public float RA_timeBetweenSequence;
		[Serialize("RA_useAim"               )] public bool RA_useAim;
		[Serialize("RA_bulletLifeTime"       )] public float RA_bulletLifeTime;
		[Serialize("RA_aimTime"              )] public float RA_aimTime;
		[Serialize("parachuteStartRight"     )] public bool parachuteStartRight;
		[Serialize("isFishing"               )] public bool isFishing;
		[Serialize("sleep"                   )] public bool sleep;
		[Serialize("useBossCollision"        )] public bool useBossCollision;
		[Serialize("isLinkedToForceField"    )] public bool isLinkedToForceField;
		[Serialize("useQuickLaunch"          )] public bool useQuickLaunch;
		[Serialize("canTriggerMagnet"        )] public bool canTriggerMagnet;
		[Serialize("noUturn"                 )] public bool noUturn;
		[Serialize("RA_anglesNoAim"          )] public CArray<Angle> RA_anglesNoAim;
		[Serialize("isDead"                  )] public bool isDead;
		[Serialize("quickLaunchUsed"         )] public bool quickLaunchUsed;
		[Serialize("lifePoints"              )] public uint lifePoints;
		[Serialize("nbTickleRewarded"        )] public uint nbTickleRewarded;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(shape));
					SerializeField(s, nameof(appearType2));
					SerializeField(s, nameof(useChargeDirect));
					SerializeField(s, nameof(useChargeSpot));
					SerializeField(s, nameof(chargeOnce));
					SerializeField(s, nameof(useTrigger));
					SerializeField(s, nameof(useRoaming));
					SerializeField(s, nameof(distRoamingUnderWater));
					SerializeField(s, nameof(distRoamingWhenFlying));
					SerializeField(s, nameof(useNightVision));
					SerializeField(s, nameof(limitLeft));
					SerializeField(s, nameof(limitRight));
					SerializeField(s, nameof(tortureTypeType));
					SerializeField(s, nameof(useRangedAttack));
					SerializeField(s, nameof(RA_countBulletBySequence));
					SerializeField(s, nameof(RA_timeBetweenBullet));
					SerializeField(s, nameof(RA_timeBetweenSequence));
					SerializeField(s, nameof(RA_useAim));
					SerializeField(s, nameof(RA_anglesNoAim));
					SerializeField(s, nameof(parachuteStartRight));
					SerializeField(s, nameof(isFishing));
					SerializeField(s, nameof(sleep));
					SerializeField(s, nameof(useBossCollision));
					SerializeField(s, nameof(isLinkedToForceField));
					SerializeField(s, nameof(useQuickLaunch));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(isDead));
					SerializeField(s, nameof(quickLaunchUsed));
					SerializeField(s, nameof(lifePoints));
					SerializeField(s, nameof(nbTickleRewarded));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(shape));
					SerializeField(s, nameof(appearType));
					SerializeField(s, nameof(useChargeDirect));
					SerializeField(s, nameof(useChargeSpot));
					SerializeField(s, nameof(chargeOnce));
					SerializeField(s, nameof(useTrigger));
					SerializeField(s, nameof(useRoaming));
					SerializeField(s, nameof(distRoamingUnderWater));
					SerializeField(s, nameof(distRoamingWhenFlying));
					SerializeField(s, nameof(useNightVision));
					SerializeField(s, nameof(limitLeft));
					SerializeField(s, nameof(limitRight));
					SerializeField(s, nameof(dashCheckHole));
					SerializeField(s, nameof(tortureTypeType));
					SerializeField(s, nameof(useRangedAttack));
					SerializeField(s, nameof(RA_countBulletBySequence));
					SerializeField(s, nameof(RA_timeBetweenBullet));
					SerializeField(s, nameof(RA_timeBetweenSequence));
					SerializeField(s, nameof(RA_useAim));
					SerializeField(s, nameof(RA_bulletLifeTime));
					SerializeField(s, nameof(RA_aimTime));
					SerializeField(s, nameof(parachuteStartRight));
					SerializeField(s, nameof(isFishing));
					SerializeField(s, nameof(sleep));
					SerializeField(s, nameof(useBossCollision));
					SerializeField(s, nameof(isLinkedToForceField));
					SerializeField(s, nameof(useQuickLaunch));
					SerializeField(s, nameof(canTriggerMagnet));
					SerializeField(s, nameof(noUturn));
					SerializeField(s, nameof(RA_anglesNoAim));
					SerializeField(s, nameof(RA_anglesNoAim));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(isDead));
					SerializeField(s, nameof(quickLaunchUsed));
					SerializeField(s, nameof(lifePoints));
					SerializeField(s, nameof(nbTickleRewarded));
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

