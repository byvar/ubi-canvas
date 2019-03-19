using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class RO2_EventScoreRecapTrigger : Event {
		[Serialize("scoreRecapSequence")] public ScoreRecapSequence scoreRecapSequence;
		[Serialize("scoreRecapSequence")] public Enum_scoreRecapSequence scoreRecapSequence;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(scoreRecapSequence));
			} else {
				SerializeField(s, nameof(scoreRecapSequence));
			}
		}
		public enum ScoreRecapSequence {
			[Serialize("ScoreRecapSequence_None"          )] None = 0,
			[Serialize("ScoreRecapSequence_Players"       )] Players = 1,
			[Serialize("ScoreRecapSequence_PrisonersShort")] PrisonersShort = 2,
			[Serialize("ScoreRecapSequence_PrisonersLong" )] PrisonersLong = 3,
		}
		public enum Enum_scoreRecapSequence {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0xBBD1624B;
	}
}

