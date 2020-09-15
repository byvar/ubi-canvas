using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeShooterGuardianBodyPart_Template : RO2_SnakeBodyPartActor_Template {
		public int health;
		public CList<uint> damageLevels;
		public float multiPlayerLifePointFactor;
		public StringID deathAnim;
		public Path tailPath;
		public StringID transfoTotailAnim;
		public StringID tailHitAnim;
		public StringID leftBubonBoneName;
		public StringID rightBubonBoneName;
		public float bubonPhantomSize;
		public int bubonHealth;
		public Path bubonRewardSpawnPath;
		public Generic<RO2_EventSpawnReward> bubonReward;
		public uint rewardNumber;
		public uint destroyRewardNumber;
		public RO2_FACTION faction;
		public RECEIVEDHITTYPE hitType;
		public uint hitLevel;
		public float attackMinDistance;
		public float attackMaxDistance;
		public StringID attackAnimation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				health = s.Serialize<int>(health, name: "health");
				damageLevels = s.SerializeObject<CList<uint>>(damageLevels, name: "damageLevels");
				multiPlayerLifePointFactor = s.Serialize<float>(multiPlayerLifePointFactor, name: "multiPlayerLifePointFactor");
				deathAnim = s.SerializeObject<StringID>(deathAnim, name: "deathAnim");
				tailPath = s.SerializeObject<Path>(tailPath, name: "tailPath");
				transfoTotailAnim = s.SerializeObject<StringID>(transfoTotailAnim, name: "transfoTotailAnim");
				tailHitAnim = s.SerializeObject<StringID>(tailHitAnim, name: "tailHitAnim");
				leftBubonBoneName = s.SerializeObject<StringID>(leftBubonBoneName, name: "leftBubonBoneName");
				rightBubonBoneName = s.SerializeObject<StringID>(rightBubonBoneName, name: "rightBubonBoneName");
				bubonPhantomSize = s.Serialize<float>(bubonPhantomSize, name: "bubonPhantomSize");
				bubonHealth = s.Serialize<int>(bubonHealth, name: "bubonHealth");
				bubonRewardSpawnPath = s.SerializeObject<Path>(bubonRewardSpawnPath, name: "bubonRewardSpawnPath");
				bubonReward = s.SerializeObject<Generic<RO2_EventSpawnReward>>(bubonReward, name: "bubonReward");
				rewardNumber = s.Serialize<uint>(rewardNumber, name: "rewardNumber");
				destroyRewardNumber = s.Serialize<uint>(destroyRewardNumber, name: "destroyRewardNumber");
				faction = s.Serialize<RO2_FACTION>(faction, name: "faction");
				hitType = s.Serialize<RECEIVEDHITTYPE>(hitType, name: "hitType");
				hitLevel = s.Serialize<uint>(hitLevel, name: "hitLevel");
				attackMinDistance = s.Serialize<float>(attackMinDistance, name: "attackMinDistance");
				attackMaxDistance = s.Serialize<float>(attackMaxDistance, name: "attackMaxDistance");
				attackAnimation = s.SerializeObject<StringID>(attackAnimation, name: "attackAnimation");
			} else {
				health = s.Serialize<int>(health, name: "health");
				damageLevels = s.SerializeObject<CList<uint>>(damageLevels, name: "damageLevels");
				multiPlayerLifePointFactor = s.Serialize<float>(multiPlayerLifePointFactor, name: "multiPlayerLifePointFactor");
				deathAnim = s.SerializeObject<StringID>(deathAnim, name: "deathAnim");
				tailPath = s.SerializeObject<Path>(tailPath, name: "tailPath");
				transfoTotailAnim = s.SerializeObject<StringID>(transfoTotailAnim, name: "transfoTotailAnim");
				tailHitAnim = s.SerializeObject<StringID>(tailHitAnim, name: "tailHitAnim");
				leftBubonBoneName = s.SerializeObject<StringID>(leftBubonBoneName, name: "leftBubonBoneName");
				rightBubonBoneName = s.SerializeObject<StringID>(rightBubonBoneName, name: "rightBubonBoneName");
				bubonPhantomSize = s.Serialize<float>(bubonPhantomSize, name: "bubonPhantomSize");
				bubonHealth = s.Serialize<int>(bubonHealth, name: "bubonHealth");
				bubonRewardSpawnPath = s.SerializeObject<Path>(bubonRewardSpawnPath, name: "bubonRewardSpawnPath");
				bubonReward = s.SerializeObject<Generic<RO2_EventSpawnReward>>(bubonReward, name: "bubonReward");
				rewardNumber = s.Serialize<uint>(rewardNumber, name: "rewardNumber");
				destroyRewardNumber = s.Serialize<uint>(destroyRewardNumber, name: "destroyRewardNumber");
				faction = s.Serialize<RO2_FACTION>(faction, name: "faction");
				hitType = s.Serialize<RECEIVEDHITTYPE>(hitType, name: "hitType");
				hitLevel = s.Serialize<uint>(hitLevel, name: "hitLevel");
				attackMinDistance = s.Serialize<float>(attackMinDistance, name: "attackMinDistance");
				attackMaxDistance = s.Serialize<float>(attackMaxDistance, name: "attackMaxDistance");
				attackAnimation = s.SerializeObject<StringID>(attackAnimation, name: "attackAnimation");
			}
		}
		public enum RO2_FACTION {
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
		public override uint? ClassCRC => 0x73162ABD;
	}
}

