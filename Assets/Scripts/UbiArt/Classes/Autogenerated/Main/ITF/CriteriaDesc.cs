using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class CriteriaDesc : CSerializable {
		public StringID name;
		public Enum_evaluation evaluation;
		public StringID eval;
		public float value;
		public bool isOR;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR
				|| Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL) {
				name = s.SerializeObject<StringID>(name, name: "name");
				eval = s.SerializeObject<StringID>(eval, name: "eval");
				value = s.Serialize<float>(value, name: "value");
				isOR = s.Serialize<bool>(isOR, name: "isOR");
			} else {
				name = s.SerializeObject<StringID>(name, name: "name");
				evaluation = s.Serialize<Enum_evaluation>(evaluation, name: "evaluation");
				if (evaluation == Enum_evaluation.Undefined) {
					eval = s.SerializeObject<StringID>(eval, name: "eval"); // StringID is a choice based on the strings of the enum (except Undefined). Check RA's CriteriaDesc::SerializeImpl
				}
				value = s.Serialize<float>(value, name: "value");
				isOR = s.Serialize<bool>(isOR, name: "isOR");
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

