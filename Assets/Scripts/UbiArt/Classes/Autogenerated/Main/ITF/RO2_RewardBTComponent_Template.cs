using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_RewardBTComponent_Template : BTAIComponent_Template {
		public bool air;
		public bool addHp;
		public Generic<RO2_EventSpawnReward> fallbackReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				addHp = s.Serialize<bool>(addHp, name: "addHp");
				fallbackReward = s.SerializeObject<Generic<RO2_EventSpawnReward>>(fallbackReward, name: "fallbackReward");
			} else {
				air = s.Serialize<bool>(air, name: "air");
				addHp = s.Serialize<bool>(addHp, name: "addHp");
				fallbackReward = s.SerializeObject<Generic<RO2_EventSpawnReward>>(fallbackReward, name: "fallbackReward");
			}
		}
		public override uint? ClassCRC => 0x529271A3;
	}
}

