using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleTriggerComponent : CSerializable {
		[Serialize("battleSetupsConfigOverride"    )] public Placeholder battleSetupsConfigOverride;
		[Description("Ally CharacterId to force on the first spawn setup")]
		[Serialize("forcedCharacterId_1"           )] public StringID forcedCharacterId_1;
		[Description("Ally CharacterId to force on the second spawn setup")]
		[Serialize("forcedCharacterId_2"           )] public StringID forcedCharacterId_2;
		[Description("Item reward for boss enemy")]
		[Serialize("bossItemReward"                )] public StringID bossItemReward;
		[Serialize("forcedInitiativeType"          )] public Enum_forcedInitiativeType forcedInitiativeType;
		[Serialize("fleeBattlePosOffsetOverride"   )] public Vector2 fleeBattlePosOffsetOverride;
		[Serialize("useFleeBattlePosOffsetOverride")] public bool useFleeBattlePosOffsetOverride;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(battleSetupsConfigOverride));
			SerializeField(s, nameof(forcedCharacterId_1));
			SerializeField(s, nameof(forcedCharacterId_2));
			SerializeField(s, nameof(bossItemReward));
			SerializeField(s, nameof(forcedInitiativeType));
			SerializeField(s, nameof(fleeBattlePosOffsetOverride));
			SerializeField(s, nameof(useFleeBattlePosOffsetOverride), boolAsByte: true);
		}
		public enum Enum_forcedInitiativeType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x2BCD844C;
	}
}

