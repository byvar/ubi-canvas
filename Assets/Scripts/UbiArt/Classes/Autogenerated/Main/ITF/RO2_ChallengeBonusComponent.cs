using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ChallengeBonusComponent : ActorComponent {
		[Serialize("challengeDuration"        )] public float challengeDuration;
		[Serialize("maxNumberToTake"          )] public uint maxNumberToTake;
		[Serialize("RecapScoreDisplayDuration")] public float RecapScoreDisplayDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(challengeDuration));
			SerializeField(s, nameof(maxNumberToTake));
			SerializeField(s, nameof(RecapScoreDisplayDuration));
		}
		public override uint? ClassCRC => 0xCD329E92;
	}
}

