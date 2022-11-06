using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class ConstraintExtended : CSerializable {
		public float offset;
		public float timeToIncrease;
		public float timeToWaitBeforeDecrease;
		public float timeToDecrease;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				offset = s.Serialize<float>(offset, name: "offset");
				timeToIncrease = s.Serialize<float>(timeToIncrease, name: "timeToIncrease");
				timeToWaitBeforeDecrease = s.Serialize<float>(timeToWaitBeforeDecrease, name: "timeToWaitBeforeDecrease");
				timeToDecrease = s.Serialize<float>(timeToDecrease, name: "timeToDecrease");
			}
		}
	}
}

