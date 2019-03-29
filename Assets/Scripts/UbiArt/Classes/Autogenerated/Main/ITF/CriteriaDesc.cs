using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class CriteriaDesc : CSerializable {
		[Serialize("name"        )] public StringID name;
		[Serialize("evaluation"  )] public Enum_evaluation evaluation;
		[Serialize("eval"        )] public StringID eval;
		[Serialize("value"       )] public float value;
		[Serialize("isOR"        )] public bool isOR;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR
				|| Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(eval));
				SerializeField(s, nameof(value));
				SerializeField(s, nameof(isOR));
			} else {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(evaluation));
				if (evaluation == Enum_evaluation.Undefined) {
					SerializeField(s, nameof(eval)); // StringID is a choice based on the strings of the enum (except Undefined). Check RA's CriteriaDesc::SerializeImpl
				}
				SerializeField(s, nameof(value));
				SerializeField(s, nameof(isOR));
			}
		}
		public enum Enum_evaluation {
			[Serialize("Undefined"          )] Undefined = 0,
			[Serialize("LessThan"           )] LessThan = 1,
			[Serialize("LessThanOrEquals"   )] LessThanOrEquals = 2,
			[Serialize("GreaterThan"        )] GreaterThan = 3,
			[Serialize("GreaterThanOrEquals")] GreaterThanOrEquals = 4,
			[Serialize("Equals"             )] Equals = 5,
			[Serialize("NotEquals"          )] NotEquals = 6,
			[Serialize("And"                )] And = 7,
		}
	}
}

