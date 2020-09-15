using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class RO2_EventScoreRecapTrigger : Event {
		public ScoreRecapSequence scoreRecapSequence;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			scoreRecapSequence = s.Serialize<ScoreRecapSequence>(scoreRecapSequence, name: "scoreRecapSequence");
		}
		public enum ScoreRecapSequence {
			[Serialize("ScoreRecapSequence_None"          )] None = 0,
			[Serialize("ScoreRecapSequence_Players"       )] Players = 1,
			[Serialize("ScoreRecapSequence_PrisonersShort")] PrisonersShort = 2,
			[Serialize("ScoreRecapSequence_PrisonersLong" )] PrisonersLong = 3,
		}
		public override uint? ClassCRC => 0xBBD1624B;
	}
}

