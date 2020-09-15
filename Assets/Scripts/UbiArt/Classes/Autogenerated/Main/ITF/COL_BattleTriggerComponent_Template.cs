using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleTriggerComponent_Template : CSerializable {
		[Serialize("battleSetupsConfig"           )] public Placeholder battleSetupsConfig;
		[Serialize("battleType"                   )] public Enum_battleType battleType;
		[Serialize("playSoundOnTrigger"           )] public bool playSoundOnTrigger;
		[Serialize("fleeBattlePosOffset"          )] public Vec2d fleeBattlePosOffset;
		[Serialize("preemptiveTimeWindowAfterStun")] public float preemptiveTimeWindowAfterStun;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(battleSetupsConfig));
			SerializeField(s, nameof(battleType));
			SerializeField(s, nameof(playSoundOnTrigger), boolAsByte: true);
			SerializeField(s, nameof(fleeBattlePosOffset));
			SerializeField(s, nameof(preemptiveTimeWindowAfterStun));
		}
		public enum Enum_battleType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xC5225A18;
	}
}

