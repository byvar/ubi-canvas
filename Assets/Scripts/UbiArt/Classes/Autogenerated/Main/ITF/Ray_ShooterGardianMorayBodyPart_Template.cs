using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_ShooterGardianMorayBodyPart_Template : BodyPart_Template {
		public StringID leftBubonBoneName;
		public StringID rightBubonBoneName;
		public float bubonPhantomSize;
		public Path bubonRewardSpawnPath;
		public int bubonHealth;
		public uint rewardNumber;
		public uint destroyRewardNumber;
		public Generic<Ray_EventSpawnReward> bubonReward;
		public Enum_RFR_0 faction;
		public Enum_RFR_1 hitType;
		public uint hitLevel;
		public Path tailPath;
		public StringID transfoTotailAnim;
		public float multiPlayerLifePointFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			leftBubonBoneName = s.SerializeObject<StringID>(leftBubonBoneName, name: "leftBubonBoneName");
			rightBubonBoneName = s.SerializeObject<StringID>(rightBubonBoneName, name: "rightBubonBoneName");
			bubonPhantomSize = s.Serialize<float>(bubonPhantomSize, name: "bubonPhantomSize");
			bubonRewardSpawnPath = s.SerializeObject<Path>(bubonRewardSpawnPath, name: "bubonRewardSpawnPath");
			bubonHealth = s.Serialize<int>(bubonHealth, name: "bubonHealth");
			rewardNumber = s.Serialize<uint>(rewardNumber, name: "rewardNumber");
			destroyRewardNumber = s.Serialize<uint>(destroyRewardNumber, name: "destroyRewardNumber");
			bubonReward = s.SerializeObject<Generic<Ray_EventSpawnReward>>(bubonReward, name: "bubonReward");
			faction = s.Serialize<Enum_RFR_0>(faction, name: "faction");
			hitType = s.Serialize<Enum_RFR_1>(hitType, name: "hitType");
			hitLevel = s.Serialize<uint>(hitLevel, name: "hitLevel");
			tailPath = s.SerializeObject<Path>(tailPath, name: "tailPath");
			transfoTotailAnim = s.SerializeObject<StringID>(transfoTotailAnim, name: "transfoTotailAnim");
			multiPlayerLifePointFactor = s.Serialize<float>(multiPlayerLifePointFactor, name: "multiPlayerLifePointFactor");
		}
		public enum Enum_RFR_0 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_14")] Value_14 = 14,
			[Serialize("Value_15")] Value_15 = 15,
			[Serialize("Value_16")] Value_16 = 16,
			[Serialize("Value_19")] Value_19 = 19,
			[Serialize("Value_20")] Value_20 = 20,
			[Serialize("Value_21")] Value_21 = 21,
			[Serialize("Value_22")] Value_22 = 22,
			[Serialize("Value_23")] Value_23 = 23,
		}
		public enum Enum_RFR_1 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
		}
		public override uint? ClassCRC => 0x31043E7F;
	}
}

