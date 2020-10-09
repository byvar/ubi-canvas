using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class Criteria : CSerializable {
		public uint inputIndex;
		public Input compare;
		public Enum_eval eval;
		public bool or;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			inputIndex = s.Serialize<uint>(inputIndex, name: "inputIndex");
			compare = s.SerializeObject<Input>(compare, name: "compare");
			eval = s.Serialize<Enum_eval>(eval, name: "eval");
			or = s.Serialize<bool>(or, name: "or");
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

