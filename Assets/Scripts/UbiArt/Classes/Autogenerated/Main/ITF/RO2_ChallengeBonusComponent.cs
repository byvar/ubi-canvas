using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ChallengeBonusComponent : ActorComponent {
		public float challengeDuration;
		public uint maxNumberToTake;
		public float RecapScoreDisplayDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			challengeDuration = s.Serialize<float>(challengeDuration, name: "challengeDuration");
			maxNumberToTake = s.Serialize<uint>(maxNumberToTake, name: "maxNumberToTake");
			RecapScoreDisplayDuration = s.Serialize<float>(RecapScoreDisplayDuration, name: "RecapScoreDisplayDuration");
		}
		public override uint? ClassCRC => 0xCD329E92;
	}
}

