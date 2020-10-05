using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleTriggerComponent_Template : CSerializable {
		public Placeholder battleSetupsConfig;
		public Enum_battleType battleType;
		public bool playSoundOnTrigger;
		public Vec2d fleeBattlePosOffset;
		public float preemptiveTimeWindowAfterStun;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			battleSetupsConfig = s.SerializeObject<Placeholder>(battleSetupsConfig, name: "battleSetupsConfig");
			battleType = s.Serialize<Enum_battleType>(battleType, name: "battleType");
			playSoundOnTrigger = s.Serialize<bool>(playSoundOnTrigger, name: "playSoundOnTrigger", options: CSerializerObject.Options.BoolAsByte);
			fleeBattlePosOffset = s.SerializeObject<Vec2d>(fleeBattlePosOffset, name: "fleeBattlePosOffset");
			preemptiveTimeWindowAfterStun = s.Serialize<float>(preemptiveTimeWindowAfterStun, name: "preemptiveTimeWindowAfterStun");
		}
		public enum Enum_battleType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xF628DD4B;
	}
}

