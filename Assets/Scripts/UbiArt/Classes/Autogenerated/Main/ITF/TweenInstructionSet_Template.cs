using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class TweenInstructionSet_Template : CSerializable {
		public StringID name;
		public CList<Generic<TweenInstruction_Template>> instructions;
		public uint iterationCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			instructions = s.SerializeObject<CList<Generic<TweenInstruction_Template>>>(instructions, name: "instructions");
			iterationCount = s.Serialize<uint>(iterationCount, name: "iterationCount");
		}
	}
}

