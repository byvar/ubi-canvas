using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class CriteriaDesc : CSerializable {
		[Serialize("name"        )] public StringID name;
		[Serialize("evaluation"  )] public Enum_evaluation evaluation;
		[Serialize("eval"        )] public StringID eval;
		[Serialize("value"       )] public float value;
		[Serialize("isOR"        )] public bool isOR;
		[Serialize("StringID__0" )] public StringID StringID__0;
		[Serialize("StringID__1" )] public StringID StringID__1;
		[Serialize("float__2"    )] public float float__2;
		[Serialize("int__3"      )] public int int__3;
		[Serialize("StringID__4" )] public StringID StringID__4;
		[Serialize("Enum_VH_0__5")] public Enum_VH_0 Enum_VH_0__5;
		[Serialize("float__6"    )] public float float__6;
		[Serialize("bool__7"     )] public bool bool__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(StringID__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(int__3));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(StringID__4));
				SerializeField(s, nameof(Enum_VH_0__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(bool__7));
			} else {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(evaluation));
				SerializeField(s, nameof(eval));
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
		public enum Enum_VH_0 {
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

