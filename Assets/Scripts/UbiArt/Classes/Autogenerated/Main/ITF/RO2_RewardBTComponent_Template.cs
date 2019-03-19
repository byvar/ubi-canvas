using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RewardBTComponent_Template : BTAIComponent_Template {
		[Serialize("air"           )] public bool air;
		[Serialize("addHp"         )] public bool addHp;
		[Serialize("fallbackReward")] public Generic<RO2_EventSpawnReward> fallbackReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(addHp));
				SerializeField(s, nameof(fallbackReward));
			} else {
				SerializeField(s, nameof(air));
				SerializeField(s, nameof(addHp));
				SerializeField(s, nameof(fallbackReward));
			}
		}
		public override uint? ClassCRC => 0x529271A3;
	}
}

