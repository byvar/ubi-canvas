using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterGardianMorayBodyPart_Template : BodyPart_Template {
		[Serialize("leftBubonBoneName"         )] public StringID leftBubonBoneName;
		[Serialize("rightBubonBoneName"        )] public StringID rightBubonBoneName;
		[Serialize("bubonPhantomSize"          )] public float bubonPhantomSize;
		[Serialize("bubonRewardSpawnPath"      )] public Path bubonRewardSpawnPath;
		[Serialize("bubonHealth"               )] public int bubonHealth;
		[Serialize("rewardNumber"              )] public uint rewardNumber;
		[Serialize("destroyRewardNumber"       )] public uint destroyRewardNumber;
		[Serialize("bubonReward"               )] public Generic<Ray_EventSpawnReward> bubonReward;
		[Serialize("faction"                   )] public Enum_RFR_0 faction;
		[Serialize("hitType"                   )] public Enum_RFR_1 hitType;
		[Serialize("hitLevel"                  )] public uint hitLevel;
		[Serialize("tailPath"                  )] public Path tailPath;
		[Serialize("transfoTotailAnim"         )] public StringID transfoTotailAnim;
		[Serialize("multiPlayerLifePointFactor")] public float multiPlayerLifePointFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(leftBubonBoneName));
			SerializeField(s, nameof(rightBubonBoneName));
			SerializeField(s, nameof(bubonPhantomSize));
			SerializeField(s, nameof(bubonRewardSpawnPath));
			SerializeField(s, nameof(bubonHealth));
			SerializeField(s, nameof(rewardNumber));
			SerializeField(s, nameof(destroyRewardNumber));
			SerializeField(s, nameof(bubonReward));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(hitType));
			SerializeField(s, nameof(hitLevel));
			SerializeField(s, nameof(tailPath));
			SerializeField(s, nameof(transfoTotailAnim));
			SerializeField(s, nameof(multiPlayerLifePointFactor));
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

