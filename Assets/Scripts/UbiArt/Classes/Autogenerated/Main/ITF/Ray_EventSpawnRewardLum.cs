using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventSpawnRewardLum : Ray_EventSpawnReward {
		[Serialize("forceYellow")] public int forceYellow;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(forceYellow));
		}
		public override uint? ClassCRC => 0x306D9812;
	}
}

