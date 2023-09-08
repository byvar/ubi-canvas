using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class CriteriaDesc {
		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR
			                                || s.Settings.Game == Game.RO || s.Settings.Game == Game.RL) {
				SetEvaluationEnum();
			} else {
				if (evaluation == Enum_evaluation.Undefined) {
					SetEvaluationEnum();
				} else {
					SetEvaluationStringID();
				}
			}
		}
		protected void SetEvaluationEnum() {
			var sid = eval?.stringID ?? 0xFFFFFFFF;
			evaluation = sid switch {
				0x8b2df96c => Enum_evaluation.LessThan,
				0x15285401 => Enum_evaluation.LessThanOrEquals,
				0x8caece26 => Enum_evaluation.GreaterThan,
				0x4d07b33f => Enum_evaluation.GreaterThanOrEquals,
				0x158d0faf => Enum_evaluation.Equals,
				0xfb9ae83 => Enum_evaluation.NotEquals,
				0x2166158f => Enum_evaluation.And,
				_ => Enum_evaluation.Undefined
			};
		}
		protected void SetEvaluationStringID() {
			eval = evaluation switch {
				Enum_evaluation.LessThan => new StringID("<"),
				Enum_evaluation.LessThanOrEquals => new StringID("<="),
				Enum_evaluation.GreaterThan => new StringID(">"),
				Enum_evaluation.GreaterThanOrEquals => new StringID(">="),
				Enum_evaluation.Equals => new StringID("=="),
				Enum_evaluation.NotEquals => new StringID("!="),
				Enum_evaluation.And => new StringID("&"),
				_ => new StringID()
			};
		}
	}
}
