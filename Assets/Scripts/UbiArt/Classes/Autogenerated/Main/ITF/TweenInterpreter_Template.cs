using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenInterpreter_Template : CSerializable {
		[Serialize("instructionSets")] public CList<TweenInstructionSet_Template> instructionSets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(instructionSets));
		}
	}
}

