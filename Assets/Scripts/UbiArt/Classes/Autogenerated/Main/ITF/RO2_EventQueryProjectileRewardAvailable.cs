using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventQueryProjectileRewardAvailable : Event {
		public bool rewardAvailable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			rewardAvailable = s.Serialize<bool>(rewardAvailable, name: "rewardAvailable");
		}
		public override uint? ClassCRC => 0x6F79798E;
	}
}

