using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class TweenInterpreter_Template : CSerializable {
		public CList<TweenInstructionSet_Template> instructionSets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			instructionSets = s.SerializeObject<CList<TweenInstructionSet_Template>>(instructionSets, name: "instructionSets");
		}
	}
}

