using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_RewardTrigger_SumWithTimer : CSerializable {
		[Serialize("timeToGet")] public float timeToGet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timeToGet));
		}
		public override uint? ClassCRC => 0x817078B7;
	}
}

