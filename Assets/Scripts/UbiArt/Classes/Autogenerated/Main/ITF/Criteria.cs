using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class Criteria : CSerializable {
		[Serialize("inputIndex")] public uint inputIndex;
		[Serialize("compare"   )] public Input compare;
		[Serialize("eval"      )] public Enum_eval eval;
		[Serialize("or"        )] public bool or;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(inputIndex));
			SerializeField(s, nameof(compare));
			SerializeField(s, nameof(eval));
			SerializeField(s, nameof(or));
		}
		public enum Enum_eval {
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

