using UnityEngine;

namespace UbiArt.ITF {
	public partial class ConstraintExtended : CSerializable {
		[Serialize("offset"                  )] public float offset;
		[Serialize("timeToIncrease"          )] public float timeToIncrease;
		[Serialize("timeToWaitBeforeDecrease")] public float timeToWaitBeforeDecrease;
		[Serialize("timeToDecrease"          )] public float timeToDecrease;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(timeToIncrease));
				SerializeField(s, nameof(timeToWaitBeforeDecrease));
				SerializeField(s, nameof(timeToDecrease));
			}
		}
	}
}

