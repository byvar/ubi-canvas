using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class RewardTrigger_SumWithTimer : RewardTrigger_Sum {
		[Serialize("timeToGet")] public float timeToGet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timeToGet));
		}
		public override uint? ClassCRC => 0x850FAEDB;
	}
}

