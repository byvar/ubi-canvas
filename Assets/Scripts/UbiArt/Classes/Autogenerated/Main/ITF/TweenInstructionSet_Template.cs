using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class TweenInstructionSet_Template : CSerializable {
		[Serialize("name"          )] public StringID name;
		[Serialize("instructions"  )] public CList<TweenInstruction_Template> instructions;
		[Serialize("iterationCount")] public uint iterationCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(instructions));
			SerializeField(s, nameof(iterationCount));
		}
	}
}

