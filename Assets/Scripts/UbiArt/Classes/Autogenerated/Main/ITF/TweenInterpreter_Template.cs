using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class TweenInterpreter_Template : CSerializable {
		[Serialize("instructionSets")] public CList<TweenInstructionSet_Template> instructionSets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(instructionSets));
		}
	}
}

