using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventTickleRewarded : Event {
		public uint rewardValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			rewardValue = s.Serialize<uint>(rewardValue, name: "rewardValue");
		}
		public override uint? ClassCRC => 0x9D2D508D;
	}
}

