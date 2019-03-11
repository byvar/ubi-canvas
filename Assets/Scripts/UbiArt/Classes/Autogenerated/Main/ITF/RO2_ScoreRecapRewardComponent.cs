using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ScoreRecapRewardComponent : ActorComponent {
		[Serialize("waitTimeBeforeDisplay")] public float waitTimeBeforeDisplay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(waitTimeBeforeDisplay));
		}
		public override uint? ClassCRC => 0x0B7958BE;
	}
}

