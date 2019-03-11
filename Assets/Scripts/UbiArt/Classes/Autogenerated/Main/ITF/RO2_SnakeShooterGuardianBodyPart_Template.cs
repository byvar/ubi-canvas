using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SnakeShooterGuardianBodyPart_Template : RO2_SnakeBodyPartActor_Template {
		[Serialize("health"                    )] public int health;
		[Serialize("damageLevels"              )] public CList<uint> damageLevels;
		[Serialize("multiPlayerLifePointFactor")] public float multiPlayerLifePointFactor;
		[Serialize("deathAnim"                 )] public StringID deathAnim;
		[Serialize("tailPath"                  )] public Path tailPath;
		[Serialize("transfoTotailAnim"         )] public StringID transfoTotailAnim;
		[Serialize("tailHitAnim"               )] public StringID tailHitAnim;
		[Serialize("leftBubonBoneName"         )] public StringID leftBubonBoneName;
		[Serialize("rightBubonBoneName"        )] public StringID rightBubonBoneName;
		[Serialize("bubonPhantomSize"          )] public float bubonPhantomSize;
		[Serialize("bubonHealth"               )] public int bubonHealth;
		[Serialize("bubonRewardSpawnPath"      )] public Path bubonRewardSpawnPath;
		[Serialize("bubonReward"               )] public Generic<RO2_EventSpawnReward> bubonReward;
		[Serialize("rewardNumber"              )] public uint rewardNumber;
		[Serialize("destroyRewardNumber"       )] public uint destroyRewardNumber;
		[Serialize("faction"                   )] public Enum_faction faction;
		[Serialize("hitType"                   )] public RECEIVEDHITTYPE hitType;
		[Serialize("hitLevel"                  )] public uint hitLevel;
		[Serialize("attackMinDistance"         )] public float attackMinDistance;
		[Serialize("attackMaxDistance"         )] public float attackMaxDistance;
		[Serialize("attackAnimation"           )] public StringID attackAnimation;
		[Serialize("health"                    )] public bool health;
		[Serialize("bubonHealth"               )] public bool bubonHealth;
		[Serialize("hitType"                   )] public Enum_hitType hitType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(health));
				SerializeField(s, nameof(damageLevels));
				SerializeField(s, nameof(multiPlayerLifePointFactor));
				SerializeField(s, nameof(deathAnim));
				SerializeField(s, nameof(tailPath));
				SerializeField(s, nameof(transfoTotailAnim));
				SerializeField(s, nameof(tailHitAnim));
				SerializeField(s, nameof(leftBubonBoneName));
				SerializeField(s, nameof(rightBubonBoneName));
				SerializeField(s, nameof(bubonPhantomSize));
				SerializeField(s, nameof(bubonHealth));
				SerializeField(s, nameof(bubonRewardSpawnPath));
				SerializeField(s, nameof(bubonReward));
				SerializeField(s, nameof(rewardNumber));
				SerializeField(s, nameof(destroyRewardNumber));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(hitType));
				SerializeField(s, nameof(hitLevel));
				SerializeField(s, nameof(attackMinDistance));
				SerializeField(s, nameof(attackMaxDistance));
				SerializeField(s, nameof(attackAnimation));
			} else {
				SerializeField(s, nameof(health));
				SerializeField(s, nameof(damageLevels));
				SerializeField(s, nameof(multiPlayerLifePointFactor));
				SerializeField(s, nameof(deathAnim));
				SerializeField(s, nameof(tailPath));
				SerializeField(s, nameof(transfoTotailAnim));
				SerializeField(s, nameof(tailHitAnim));
				SerializeField(s, nameof(leftBubonBoneName));
				SerializeField(s, nameof(rightBubonBoneName));
				SerializeField(s, nameof(bubonPhantomSize));
				SerializeField(s, nameof(bubonHealth));
				SerializeField(s, nameof(bubonRewardSpawnPath));
				SerializeField(s, nameof(bubonReward));
				SerializeField(s, nameof(rewardNumber));
				SerializeField(s, nameof(destroyRewardNumber));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(hitType));
				SerializeField(s, nameof(hitLevel));
				SerializeField(s, nameof(attackMinDistance));
				SerializeField(s, nameof(attackMaxDistance));
				SerializeField(s, nameof(attackAnimation));
			}
		}
		public enum Enum_faction {
			[Serialize("FACTION_UNKNOWN"     )] FACTION_UNKNOWN = -1,
			[Serialize("RO2_FACTION_NEUTRAL" )] RO2_FACTION_NEUTRAL = 0,
			[Serialize("RO2_FACTION_FRIENDLY")] RO2_FACTION_FRIENDLY = 1,
			[Serialize("RO2_FACTION_ENEMY"   )] RO2_FACTION_ENEMY = 2,
			[Serialize("RO2_FACTION_PLAYER"  )] RO2_FACTION_PLAYER = 3,
		}
		public enum RECEIVEDHITTYPE {
			[Serialize("RECEIVEDHITTYPE_UNKNOWN"    )] UNKNOWN = -1,
			[Serialize("RECEIVEDHITTYPE_FRONTPUNCH" )] FRONTPUNCH = 0,
			[Serialize("RECEIVEDHITTYPE_UPPUNCH"    )] UPPUNCH = 1,
			[Serialize("RECEIVEDHITTYPE_EJECTXY"    )] EJECTXY = 3,
			[Serialize("RECEIVEDHITTYPE_HURTBOUNCE" )] HURTBOUNCE = 4,
			[Serialize("RECEIVEDHITTYPE_DARKTOONIFY")] DARKTOONIFY = 5,
			[Serialize("RECEIVEDHITTYPE_EARTHQUAKE" )] EARTHQUAKE = 6,
			[Serialize("RECEIVEDHITTYPE_SHOOTER"    )] SHOOTER = 7,
		}
		public enum Enum_faction {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
		}
		public enum Enum_hitType {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
		}
		public override uint? ClassCRC => 0x73162ABD;
	}
}

