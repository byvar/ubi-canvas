using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_RewardTrigger_SumWithTimer : CSerializable {
		public float timeToGet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timeToGet = s.Serialize<float>(timeToGet, name: "timeToGet");
		}
		public override uint? ClassCRC => 0x817078B7;
	}
}

